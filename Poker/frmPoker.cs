using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        #region 欄位
        PictureBox[] pic = new PictureBox[5];
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        int player1Money = 1000000;
        int player2Money = 1000000;
        int currentPlayer = 1;
        int currentBet = 0;
        bool isTwoPlayerMode = false;
        #endregion

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            InitializePlayerPictures();
            UpdateMoneyLabel();
        }

        #region 自定義方法
        private int CurrentMoney
        {
            get { return currentPlayer == 1 ? player1Money : player2Money; }
            set
            {
                if (currentPlayer == 1) player1Money = value;
                else player2Money = value;
            }
        }

        private void InitializePoker()
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Enabled = false;
                pic[i].Tag = "back";
                pic[i].Visible = true;
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].Click += Pic_Click;
            }
        }

        private void InitializePlayerPictures()
        {
            picPlayer1.Image = CreatePlayerImage(1, false);
            picPlayer2.Image = CreatePlayerImage(2, false);
        }

        private Image CreatePlayerImage(int playerNo, bool active)
        {
            Bitmap bmp = new Bitmap(110, 110);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Color bg = playerNo == 1 ? Color.LightSkyBlue : Color.LightPink;
                Color body = playerNo == 1 ? Color.RoyalBlue : Color.IndianRed;
                Color border = active ? Color.Gold : Color.Gray;

                g.Clear(bg);
                using (Pen pen = new Pen(border, active ? 6 : 3))
                {
                    g.DrawRectangle(pen, 2, 2, 105, 105);
                }

                using (Brush faceBrush = new SolidBrush(Color.Bisque))
                using (Brush bodyBrush = new SolidBrush(body))
                using (Brush eyeBrush = new SolidBrush(Color.Black))
                using (Brush textBrush = new SolidBrush(Color.White))
                using (Font font = new Font("Microsoft JhengHei", 18, FontStyle.Bold))
                {
                    if (playerNo == 1)
                    {
                        g.FillEllipse(faceBrush, 34, 18, 42, 42);
                        g.FillRectangle(bodyBrush, 27, 66, 56, 28);
                        g.FillEllipse(eyeBrush, 44, 34, 5, 5);
                        g.FillEllipse(eyeBrush, 61, 34, 5, 5);
                    }
                    else
                    {
                        g.FillEllipse(faceBrush, 31, 18, 48, 42);
                        g.FillEllipse(bodyBrush, 25, 66, 60, 28);
                        g.FillEllipse(eyeBrush, 43, 34, 5, 5);
                        g.FillEllipse(eyeBrush, 62, 34, 5, 5);
                        using (Pen hairPen = new Pen(Color.SaddleBrown, 4))
                        {
                            g.DrawArc(hairPen, 29, 12, 52, 28, 180, 180);
                        }
                    }

                    g.DrawString("P" + playerNo, font, textBrush, 36, 70);
                }
            }
            return bmp;
        }

        private void UpdatePlayerPictures()
        {
            picPlayer1.Image = CreatePlayerImage(1, currentPlayer == 1);
            picPlayer2.Image = CreatePlayerImage(2, isTwoPlayerMode && currentPlayer == 2);
            lblPicPlayer1.Text = currentPlayer == 1 ? "玩家 1（目前）" : "玩家 1";
            lblPicPlayer2.Text = isTwoPlayerMode && currentPlayer == 2 ? "玩家 2（目前）" : "玩家 2";
        }

        private void ShowCards()
        {
            for (int i = 0; i < playerPoker.Length; i++)
            {
                pic[i].Image = this.GetImage($"pic{playerPoker[i] + 1}");
            }
        }

        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private void UpdateMoneyLabel()
        {
            txtMoney.Text = CurrentMoney.ToString();
            txtPlayer1Money.Text = player1Money.ToString();
            txtPlayer2Money.Text = player2Money.ToString();
            lblCurrentPlayer.Text = isTwoPlayerMode ? $"目前玩家：玩家 {currentPlayer}" : "目前玩家：單人";
            UpdatePlayerPictures();
        }

        private int GetOdds(string pokerType)
        {
            switch (pokerType)
            {
                case "皇家同花順": return 250;
                case "同花順": return 50;
                case "四條": return 25;
                case "葫蘆": return 9;
                case "同花": return 6;
                case "順子": return 4;
                case "三條": return 3;
                case "兩對": return 2;
                case "一對": return 1;
                default: return 0;
            }
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        private void SwitchPlayer()
        {
            if (!isTwoPlayerMode) return;

            currentPlayer = currentPlayer == 1 ? 2 : 1;
            UpdateMoneyLabel();
            lblResult.Text += $"；換玩家 {currentPlayer} 下注";
        }

        private void ClearTable()
        {
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetImage("back");
                pic[i].Enabled = false;
                pic[i].Tag = "back";
            }
        }

        private void CalculatePokerResult(out string pokerType, out string result)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];

            for (int i = 0; i < playerPoker.Length; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }

            int[] colorCount = new int[4];
            int[] pointCount = new int[13];

            for (int i = 0; i < pokerColor.Length; i++)
            {
                colorCount[pokerColor[i]]++;
                pointCount[pokerPoint[i]]++;
            }

            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);

            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            bool isFlush = colorCount[0] == 5;
            bool isSingle = pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 && pointCount[3] == 1 && pointCount[4] == 1;
            bool isDiffFour = pokerPoint.Max() - pokerPoint.Min() == 4;
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) && pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            bool isRoyalFlush = isFlush && isRoyal;
            bool isStraightFlush = isFlush && isSingle && isDiffFour;
            bool isStraight = isSingle && (isDiffFour || isRoyal);
            bool isFourOfAKind = pointCount[0] == 4;
            bool isFullHouse = pointCount[0] == 3 && pointCount[1] == 2;
            bool isThreeOfAKind = pointCount[0] == 3 && pointCount[1] == 1;
            bool isTwoPair = pointCount[0] == 2 && pointCount[1] == 2;
            bool isOnePair = pointCount[0] == 2 && pointCount[1] == 1;

            pokerType = "雜牌";
            result = "雜牌";

            if (isRoyalFlush)
            {
                pokerType = "皇家同花順";
                result = $"{colorList[0]} 皇家同花順";
            }
            else if (isStraightFlush)
            {
                pokerType = "同花順";
                result = $"{colorList[0]} 同花順";
            }
            else if (isFourOfAKind)
            {
                pokerType = "四條";
                result = $"{pointList[0]} 四條";
            }
            else if (isFullHouse)
            {
                pokerType = "葫蘆";
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
            }
            else if (isFlush)
            {
                pokerType = "同花";
                result = $"{colorList[0]} 同花";
            }
            else if (isStraight)
            {
                pokerType = "順子";
                result = "順子";
            }
            else if (isThreeOfAKind)
            {
                pokerType = "三條";
                result = $"{pointList[0]} 三條";
            }
            else if (isTwoPair)
            {
                pokerType = "兩對";
                result = $"{pointList[0]},{pointList[1]} 兩對";
            }
            else if (isOnePair)
            {
                pokerType = "一對";
                result = $"{pointList[0]} 一對";
            }
        }
        #endregion

        #region 事件處理程序
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int index = int.Parse(p.Name.Replace("pic", ""));
            int cardNum = playerPoker[index] + 1;

            if (p.Tag.ToString() == "back")
            {
                p.Tag = "front";
                p.Image = GetImage(cardNum.ToString().StartsWith("pic") ? cardNum.ToString() : $"pic{cardNum}");
            }
            else
            {
                p.Tag = "back";
                p.Image = GetImage("back");
            }
        }

        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            if (currentBet <= 0)
            {
                MessageBox.Show("請先輸入押注金額並按下下注。", "提醒");
                return;
            }

            lblResult.Text = "";
            ClearTable();

            for (int i = 0; i < allPoker.Length; i++) allPoker[i] = i;
            Shuffle();
            await Task.Delay(500);

            for (int i = 0; i < playerPoker.Length; i++) playerPoker[i] = allPoker[i];

            ShowCards();

            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }

            btnChangeCard.Enabled = true;
            btnDealCard.Enabled = false;
            btnBet.Enabled = false;
            txtBet.Enabled = false;
            rdoSingle.Enabled = false;
            rdoDouble.Enabled = false;
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int startIndex = 5;

            for (int i = 0; i < playerPoker.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[startIndex];
                    pic[i].Image = GetImage($"pic{playerPoker[i] + 1}");
                    pic[i].Tag = "front";
                    startIndex++;
                }
            }

            for (int i = 0; i < pic.Length; i++) pic[i].Enabled = false;

            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string pokerType;
            string result;
            CalculatePokerResult(out pokerType, out result);

            int odds = GetOdds(pokerType);
            int winMoney = currentBet * odds;
            CurrentMoney = CurrentMoney + winMoney;
            UpdateMoneyLabel();

            lblResult.Text = $"玩家 {currentPlayer}：{result}，賠率 {odds}，中獎 {winMoney}";

            currentBet = 0;
            txtBet.Text = "";
            txtBet.Enabled = true;
            btnBet.Enabled = true;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnDealCard.Enabled = false;
            rdoSingle.Enabled = true;
            rdoDouble.Enabled = true;

            SwitchPlayer();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int bet;
            if (!int.TryParse(txtBet.Text, out bet) || bet <= 0)
            {
                MessageBox.Show("押注金額必須是大於 0 的整數。", "輸入錯誤");
                txtBet.Focus();
                return;
            }

            if (bet > CurrentMoney)
            {
                MessageBox.Show("押注金額不能大於目前玩家的金額。", "輸入錯誤");
                txtBet.Focus();
                return;
            }

            currentBet = bet;
            CurrentMoney = CurrentMoney - bet;
            UpdateMoneyLabel();
            lblResult.Text = $"玩家 {currentPlayer} 已下注 {currentBet}，請按發牌";

            btnDealCard.Enabled = true;
            btnBet.Enabled = false;
            txtBet.Enabled = false;
            rdoSingle.Enabled = false;
            rdoDouble.Enabled = false;
        }

        private void rdoSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdoSingle.Checked) return;
            isTwoPlayerMode = false;
            currentPlayer = 1;
            player1Money = 1000000;
            player2Money = 1000000;
            currentBet = 0;
            ClearTable();
            UpdateMoneyLabel();
            lblResult.Text = "單人模式";
            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnBet.Enabled = true;
            txtBet.Enabled = true;
        }

        private void rdoDouble_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdoDouble.Checked) return;
            isTwoPlayerMode = true;
            currentPlayer = 1;
            player1Money = 1000000;
            player2Money = 1000000;
            currentBet = 0;
            ClearTable();
            UpdateMoneyLabel();
            lblResult.Text = "雙人模式：玩家 1 先下注";
            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
            btnBet.Enabled = true;
            txtBet.Enabled = true;
        }

        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.btnDealCard.Enabled == false)
            {
                switch (e.KeyChar)
                {
                    case 'q':
                        playerPoker[0] = 51; playerPoker[1] = 47; playerPoker[2] = 43; playerPoker[3] = 39; playerPoker[4] = 3;
                        break;
                    case 'w':
                        playerPoker[0] = 37; playerPoker[1] = 33; playerPoker[2] = 29; playerPoker[3] = 25; playerPoker[4] = 21;
                        break;
                    case 'e':
                        playerPoker[0] = 50; playerPoker[1] = 38; playerPoker[2] = 34; playerPoker[3] = 22; playerPoker[4] = 18;
                        break;
                    case 'r':
                        playerPoker[0] = 48; playerPoker[1] = 39; playerPoker[2] = 38; playerPoker[3] = 37; playerPoker[4] = 36;
                        break;
                    case 't':
                        playerPoker[0] = 30; playerPoker[1] = 29; playerPoker[2] = 6; playerPoker[3] = 5; playerPoker[4] = 4;
                        break;
                    case 'y':
                        playerPoker[0] = 48; playerPoker[1] = 39; playerPoker[2] = 15; playerPoker[3] = 14; playerPoker[4] = 13;
                        break;
                }

                this.ShowCards();
            }
        }
        #endregion
    }
}
