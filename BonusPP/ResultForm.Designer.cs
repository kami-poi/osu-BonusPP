namespace BonusPP;

partial class ResultForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
        msg = new GroupBox();
        tableLayout = new TableLayoutPanel();
        rankedScoreNum = new Label();
        totalPpWithoutBonus = new Label();
        totalPP = new Label();
        lBonusPP = new Label();
        lTotalPP = new Label();
        lTotalPpWithoutBonus = new Label();
        lNumRankedScores = new Label();
        bonusPP = new Label();
        graph = new GroupBox();
        graphPanel = new Graph();
        msg.SuspendLayout();
        tableLayout.SuspendLayout();
        graph.SuspendLayout();
        SuspendLayout();
        // 
        // msg
        // 
        msg.Controls.Add(tableLayout);
        msg.Location = new Point(12, 12);
        msg.Name = "msg";
        msg.Size = new Size(325, 126);
        msg.TabIndex = 0;
        msg.TabStop = false;
        msg.Text = "name(mode)";
        // 
        // tableLayout
        // 
        tableLayout.ColumnCount = 2;
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableLayout.Controls.Add(rankedScoreNum, 1, 3);
        tableLayout.Controls.Add(totalPpWithoutBonus, 1, 2);
        tableLayout.Controls.Add(totalPP, 1, 1);
        tableLayout.Controls.Add(lBonusPP, 0, 0);
        tableLayout.Controls.Add(lTotalPP, 0, 1);
        tableLayout.Controls.Add(lTotalPpWithoutBonus, 0, 2);
        tableLayout.Controls.Add(lNumRankedScores, 0, 3);
        tableLayout.Controls.Add(bonusPP, 1, 0);
        tableLayout.Dock = DockStyle.Fill;
        tableLayout.Location = new Point(3, 19);
        tableLayout.Name = "tableLayout";
        tableLayout.RowCount = 4;
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayout.Size = new Size(319, 104);
        tableLayout.TabIndex = 0;
        // 
        // rankedScoreNum
        // 
        rankedScoreNum.Anchor = AnchorStyles.Left;
        rankedScoreNum.AutoSize = true;
        rankedScoreNum.Location = new Point(226, 82);
        rankedScoreNum.Name = "rankedScoreNum";
        rankedScoreNum.Size = new Size(15, 17);
        rankedScoreNum.TabIndex = 7;
        rankedScoreNum.Text = "0";
        // 
        // totalPpWithoutBonus
        // 
        totalPpWithoutBonus.Anchor = AnchorStyles.Left;
        totalPpWithoutBonus.AutoSize = true;
        totalPpWithoutBonus.Location = new Point(226, 56);
        totalPpWithoutBonus.Name = "totalPpWithoutBonus";
        totalPpWithoutBonus.Size = new Size(15, 17);
        totalPpWithoutBonus.TabIndex = 6;
        totalPpWithoutBonus.Text = "0";
        // 
        // totalPP
        // 
        totalPP.Anchor = AnchorStyles.Left;
        totalPP.AutoSize = true;
        totalPP.Location = new Point(226, 30);
        totalPP.Name = "totalPP";
        totalPP.Size = new Size(15, 17);
        totalPP.TabIndex = 5;
        totalPP.Text = "0";
        // 
        // lBonusPP
        // 
        lBonusPP.Anchor = AnchorStyles.Left;
        lBonusPP.AutoSize = true;
        lBonusPP.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
        lBonusPP.Location = new Point(3, 4);
        lBonusPP.Name = "lBonusPP";
        lBonusPP.Size = new Size(73, 17);
        lBonusPP.TabIndex = 0;
        lBonusPP.Text = "Bonus PP: ";
        // 
        // lTotalPP
        // 
        lTotalPP.Anchor = AnchorStyles.Left;
        lTotalPP.AutoSize = true;
        lTotalPP.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
        lTotalPP.Location = new Point(3, 30);
        lTotalPP.Name = "lTotalPP";
        lTotalPP.Size = new Size(67, 17);
        lTotalPP.TabIndex = 1;
        lTotalPP.Text = "Total PP: ";
        // 
        // lTotalPpWithoutBonus
        // 
        lTotalPpWithoutBonus.Anchor = AnchorStyles.Left;
        lTotalPpWithoutBonus.AutoSize = true;
        lTotalPpWithoutBonus.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
        lTotalPpWithoutBonus.Location = new Point(3, 56);
        lTotalPpWithoutBonus.Name = "lTotalPpWithoutBonus";
        lTotalPpWithoutBonus.Size = new Size(171, 17);
        lTotalPpWithoutBonus.TabIndex = 2;
        lTotalPpWithoutBonus.Text = "Total PP (without bonus): ";
        // 
        // lNumRankedScores
        // 
        lNumRankedScores.Anchor = AnchorStyles.Left;
        lNumRankedScores.AutoSize = true;
        lNumRankedScores.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
        lNumRankedScores.Location = new Point(3, 82);
        lNumRankedScores.Name = "lNumRankedScores";
        lNumRankedScores.Size = new Size(157, 17);
        lNumRankedScores.TabIndex = 3;
        lNumRankedScores.Text = "Ranked Score Numbers: ";
        // 
        // bonusPP
        // 
        bonusPP.Anchor = AnchorStyles.Left;
        bonusPP.AutoSize = true;
        bonusPP.Location = new Point(226, 4);
        bonusPP.Name = "bonusPP";
        bonusPP.Size = new Size(15, 17);
        bonusPP.TabIndex = 4;
        bonusPP.Text = "0";
        // 
        // graph
        // 
        graph.AutoSize = true;
        graph.Controls.Add(graphPanel);
        graph.Location = new Point(15, 144);
        graph.Name = "graph";
        graph.Size = new Size(322, 141);
        graph.TabIndex = 1;
        graph.TabStop = false;
        graph.Text = "PP Score Graph";
        // 
        // graphPanel
        // 
        graphPanel.Dock = DockStyle.Fill;
        graphPanel.Location = new Point(3, 19);
        graphPanel.Name = "graphPanel";
        graphPanel.Padding = new Padding(0, 0, 0, 3);
        graphPanel.Size = new Size(316, 119);
        graphPanel.TabIndex = 0;
        // 
        // ResultForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(349, 297);
        Controls.Add(graph);
        Controls.Add(msg);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ResultForm";
        Text = "Bonus PP";
        Load += ResultForm_Load;
        msg.ResumeLayout(false);
        tableLayout.ResumeLayout(false);
        tableLayout.PerformLayout();
        graph.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox msg;
    private GroupBox graph;
    private TableLayoutPanel tableLayout;
    private Label lBonusPP;
    private Label lTotalPP;
    private Label lTotalPpWithoutBonus;
    private Label lNumRankedScores;
    private Label rankedScoreNum;
    private Label totalPpWithoutBonus;
    private Label totalPP;
    private Label bonusPP;
    private Graph graphPanel;
}