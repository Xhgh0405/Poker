namespace Poker
{
    partial class frmPoker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtPlayer2Money = new System.Windows.Forms.TextBox();
            this.txtPlayer1Money = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.rdoDouble = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPicPlayer1 = new System.Windows.Forms.Label();
            this.lblPicPlayer2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpBet.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.grpPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(12, 12);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(720, 160);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.lblCurrentPlayer);
            this.grpBet.Controls.Add(this.txtPlayer2Money);
            this.grpBet.Controls.Add(this.txtPlayer1Money);
            this.grpBet.Controls.Add(this.lblPlayer2);
            this.grpBet.Controls.Add(this.lblPlayer1);
            this.grpBet.Controls.Add(this.rdoDouble);
            this.grpBet.Controls.Add(this.rdoSingle);
            this.grpBet.Controls.Add(this.lblMode);
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBet);
            this.grpBet.Controls.Add(this.txtMoney);
            this.grpBet.Controls.Add(this.lblBet);
            this.grpBet.Controls.Add(this.lblMoney);
            this.grpBet.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(12, 178);
            this.grpBet.Name = "grpBet";
            this.grpBet.Size = new System.Drawing.Size(720, 116);
            this.grpBet.TabIndex = 1;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注與模式";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(450, 33);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(121, 20);
            this.lblCurrentPlayer.TabIndex = 12;
            this.lblCurrentPlayer.Text = "目前玩家：單人";
            // 
            // txtPlayer2Money
            // 
            this.txtPlayer2Money.Location = new System.Drawing.Point(559, 72);
            this.txtPlayer2Money.Name = "txtPlayer2Money";
            this.txtPlayer2Money.ReadOnly = true;
            this.txtPlayer2Money.Size = new System.Drawing.Size(120, 29);
            this.txtPlayer2Money.TabIndex = 11;
            this.txtPlayer2Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlayer1Money
            // 
            this.txtPlayer1Money.Location = new System.Drawing.Point(331, 72);
            this.txtPlayer1Money.Name = "txtPlayer1Money";
            this.txtPlayer1Money.ReadOnly = true;
            this.txtPlayer1Money.Size = new System.Drawing.Size(120, 29);
            this.txtPlayer1Money.TabIndex = 10;
            this.txtPlayer1Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(483, 76);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(70, 20);
            this.lblPlayer2.TabIndex = 9;
            this.lblPlayer2.Text = "玩家2錢";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(255, 76);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(70, 20);
            this.lblPlayer1.TabIndex = 8;
            this.lblPlayer1.Text = "玩家1錢";
            // 
            // rdoDouble
            // 
            this.rdoDouble.AutoSize = true;
            this.rdoDouble.Location = new System.Drawing.Point(364, 31);
            this.rdoDouble.Name = "rdoDouble";
            this.rdoDouble.Size = new System.Drawing.Size(75, 24);
            this.rdoDouble.TabIndex = 7;
            this.rdoDouble.Text = "雙人";
            this.rdoDouble.UseVisualStyleBackColor = true;
            this.rdoDouble.CheckedChanged += new System.EventHandler(this.rdoDouble_CheckedChanged);
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(283, 31);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(75, 24);
            this.rdoSingle.TabIndex = 6;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "單人";
            this.rdoSingle.UseVisualStyleBackColor = true;
            this.rdoSingle.CheckedChanged += new System.EventHandler(this.rdoSingle_CheckedChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(231, 33);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(41, 20);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "模式";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(155, 70);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(67, 32);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "下注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(85, 71);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(64, 29);
            this.txtBet.TabIndex = 3;
            this.txtBet.Text = "500";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(85, 27);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(120, 29);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(6, 75);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(73, 20);
            this.lblBet.TabIndex = 2;
            this.lblBet.Text = "押注金額";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(6, 31);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(73, 20);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "目前金額";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(12, 300);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(720, 80);
            this.grpButton.TabIndex = 2;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(252, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(450, 36);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(164, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 36);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(94, 28);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(64, 36);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Enabled = false;
            this.btnDealCard.Location = new System.Drawing.Point(21, 28);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(67, 36);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.lblPicPlayer2);
            this.grpPlayers.Controls.Add(this.lblPicPlayer1);
            this.grpPlayers.Controls.Add(this.picPlayer2);
            this.grpPlayers.Controls.Add(this.picPlayer1);
            this.grpPlayers.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPlayers.Location = new System.Drawing.Point(744, 12);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(180, 368);
            this.grpPlayers.TabIndex = 3;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "玩家狀態";
            // 
            // picPlayer1
            // 
            this.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer1.Location = new System.Drawing.Point(35, 55);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(110, 110);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 0;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer2.Location = new System.Drawing.Point(35, 215);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(110, 110);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 1;
            this.picPlayer2.TabStop = false;
            // 
            // lblPicPlayer1
            // 
            this.lblPicPlayer1.Location = new System.Drawing.Point(10, 28);
            this.lblPicPlayer1.Name = "lblPicPlayer1";
            this.lblPicPlayer1.Size = new System.Drawing.Size(160, 24);
            this.lblPicPlayer1.TabIndex = 2;
            this.lblPicPlayer1.Text = "玩家 1";
            this.lblPicPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPicPlayer2
            // 
            this.lblPicPlayer2.Location = new System.Drawing.Point(10, 188);
            this.lblPicPlayer2.Name = "lblPicPlayer2";
            this.lblPicPlayer2.Size = new System.Drawing.Size(160, 24);
            this.lblPicPlayer2.TabIndex = 3;
            this.lblPicPlayer2.Text = "玩家 2";
            this.lblPicPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 393);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.grpPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoDouble;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtPlayer1Money;
        private System.Windows.Forms.TextBox txtPlayer2Money;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Label lblPicPlayer1;
        private System.Windows.Forms.Label lblPicPlayer2;
    }
}
