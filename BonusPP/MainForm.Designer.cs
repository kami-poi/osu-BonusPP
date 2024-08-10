namespace BonusPP;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        form = new Panel();
        fields = new TableLayoutPanel();
        api = new TextBox();
        name = new TextBox();
        modes = new ComboBox();
        labels = new TableLayoutPanel();
        lApi = new Label();
        lName = new Label();
        lMode = new Label();
        info = new TableLayoutPanel();
        git = new LinkLabel();
        ver = new Label();
        options = new TableLayoutPanel();
        ok = new Button();
        cancel = new Button();
        form.SuspendLayout();
        fields.SuspendLayout();
        labels.SuspendLayout();
        info.SuspendLayout();
        options.SuspendLayout();
        SuspendLayout();
        // 
        // form
        // 
        form.Controls.Add(fields);
        form.Controls.Add(labels);
        form.Controls.Add(info);
        form.Dock = DockStyle.Fill;
        form.Location = new Point(0, 0);
        form.Name = "form";
        form.Size = new Size(335, 139);
        form.TabIndex = 0;
        // 
        // fields
        // 
        fields.AutoSize = true;
        fields.ColumnCount = 1;
        fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        fields.Controls.Add(api, 0, 0);
        fields.Controls.Add(name, 0, 1);
        fields.Controls.Add(modes, 0, 2);
        fields.Dock = DockStyle.Fill;
        fields.Location = new Point(73, 0);
        fields.Name = "fields";
        fields.Padding = new Padding(4);
        fields.RowCount = 3;
        fields.RowStyles.Add(new RowStyle());
        fields.RowStyles.Add(new RowStyle());
        fields.RowStyles.Add(new RowStyle());
        fields.Size = new Size(262, 97);
        fields.TabIndex = 4;
        // 
        // api
        // 
        api.BorderStyle = BorderStyle.FixedSingle;
        api.Dock = DockStyle.Fill;
        api.Location = new Point(7, 7);
        api.MaxLength = 40;
        api.Name = "api";
        api.Size = new Size(248, 23);
        api.TabIndex = 0;
        // 
        // name
        // 
        name.BorderStyle = BorderStyle.FixedSingle;
        name.Dock = DockStyle.Fill;
        name.ImeMode = ImeMode.Disable;
        name.Location = new Point(7, 36);
        name.MaxLength = 30;
        name.Name = "name";
        name.Size = new Size(248, 23);
        name.TabIndex = 1;
        // 
        // modes
        // 
        modes.Dock = DockStyle.Fill;
        modes.DropDownStyle = ComboBoxStyle.DropDownList;
        modes.FormattingEnabled = true;
        modes.Items.AddRange(new object[] { "osu! Standard", "osu! Taiko", "osu! Catch the Beat", "osu! Mania" });
        modes.Location = new Point(7, 65);
        modes.Name = "modes";
        modes.SelectedIndex = 0;
        modes.Size = new Size(248, 25);
        modes.TabIndex = 2;
        // 
        // labels
        // 
        labels.AutoSize = true;
        labels.ColumnCount = 1;
        labels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        labels.Controls.Add(lApi, 0, 0);
        labels.Controls.Add(lName, 0, 1);
        labels.Controls.Add(lMode, 0, 2);
        labels.Dock = DockStyle.Left;
        labels.Location = new Point(0, 0);
        labels.Name = "labels";
        labels.Padding = new Padding(4);
        labels.RowCount = 3;
        labels.RowStyles.Add(new RowStyle());
        labels.RowStyles.Add(new RowStyle());
        labels.RowStyles.Add(new RowStyle());
        labels.Size = new Size(73, 97);
        labels.TabIndex = 3;
        // 
        // lApi
        // 
        lApi.Location = new Point(7, 7);
        lApi.Margin = new Padding(3);
        lApi.Name = "lApi";
        lApi.Size = new Size(59, 23);
        lApi.TabIndex = 0;
        lApi.Text = "API Key: ";
        // 
        // lName
        // 
        lName.Location = new Point(7, 36);
        lName.Margin = new Padding(3);
        lName.Name = "lName";
        lName.Size = new Size(42, 23);
        lName.TabIndex = 1;
        lName.Text = "User: ";
        // 
        // lMode
        // 
        lMode.Location = new Point(7, 65);
        lMode.Margin = new Padding(3);
        lMode.Name = "lMode";
        lMode.Size = new Size(50, 23);
        lMode.TabIndex = 2;
        lMode.Text = "Mode: ";
        // 
        // info
        // 
        info.AutoSize = true;
        info.ColumnCount = 1;
        info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        info.Controls.Add(git, 0, 0);
        info.Controls.Add(ver, 0, 0);
        info.Dock = DockStyle.Bottom;
        info.Location = new Point(0, 97);
        info.Name = "info";
        info.Padding = new Padding(5, 5, 5, 0);
        info.RowCount = 1;
        info.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        info.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        info.Size = new Size(335, 42);
        info.TabIndex = 5;
        // 
        // git
        // 
        git.AutoSize = true;
        git.Dock = DockStyle.Top;
        git.Location = new Point(8, 22);
        git.Name = "git";
        git.Size = new Size(319, 17);
        git.TabIndex = 1;
        git.TabStop = true;
        git.Text = "GitHub";
        git.TextAlign = ContentAlignment.TopCenter;
        git.LinkClicked += git_LinkClicked;
        // 
        // ver
        // 
        ver.AutoSize = true;
        ver.Dock = DockStyle.Top;
        ver.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 134);
        ver.Location = new Point(8, 5);
        ver.Name = "ver";
        ver.Size = new Size(319, 17);
        ver.TabIndex = 0;
        ver.Text = "Version: v1.0, latest version: loading";
        ver.TextAlign = ContentAlignment.TopCenter;
        // 
        // options
        // 
        options.AutoSize = true;
        options.ColumnCount = 2;
        options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        options.Controls.Add(ok, 0, 0);
        options.Controls.Add(cancel, 1, 0);
        options.Dock = DockStyle.Bottom;
        options.Location = new Point(0, 139);
        options.Name = "options";
        options.RowCount = 1;
        options.RowStyles.Add(new RowStyle());
        options.Size = new Size(335, 29);
        options.TabIndex = 1;
        // 
        // ok
        // 
        ok.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ok.Location = new Point(72, 3);
        ok.Margin = new Padding(3, 3, 20, 3);
        ok.Name = "ok";
        ok.Size = new Size(75, 23);
        ok.TabIndex = 0;
        ok.Text = "OK";
        ok.UseVisualStyleBackColor = true;
        ok.Click += ok_Click;
        // 
        // cancel
        // 
        cancel.Location = new Point(187, 3);
        cancel.Margin = new Padding(20, 3, 3, 3);
        cancel.Name = "cancel";
        cancel.Size = new Size(75, 23);
        cancel.TabIndex = 1;
        cancel.Text = "Cancel";
        cancel.UseVisualStyleBackColor = true;
        cancel.Click += cancel_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new Size(335, 168);
        Controls.Add(form);
        Controls.Add(options);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        Text = "Bonus PP";
        form.ResumeLayout(false);
        form.PerformLayout();
        fields.ResumeLayout(false);
        fields.PerformLayout();
        labels.ResumeLayout(false);
        info.ResumeLayout(false);
        info.PerformLayout();
        options.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel form;
    private Label lApi;
    private Label lName;
    private Label lMode;
    private TextBox api;
    private TextBox name;
    private ComboBox modes;
    private TableLayoutPanel labels;
    private TableLayoutPanel fields;
    private TableLayoutPanel info;
    private Label ver;
    private LinkLabel git;
    private TableLayoutPanel options;
    private Button ok;
    private Button cancel;
}