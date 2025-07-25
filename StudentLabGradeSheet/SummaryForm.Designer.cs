using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentLabGradeSheet
{
    partial class SummaryForm
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
            panelTop = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            panelGrades = new Panel();
            txtTopPerformers = new TextBox();
            lblTopPerformers = new Label();
            txtGradeDistribution = new TextBox();
            lblGradeDistribution = new Label();
            panelStats = new Panel();
            lblAvgProject = new Label();
            lblAvgAssignment = new Label();
            lblAvgOnline = new Label();
            lblAvgAttendance = new Label();
            lblLowestTotal = new Label();
            lblHighestTotal = new Label();
            lblAvgTotal = new Label();
            lblTotalStudents = new Label();
            lblStatsHeader = new Label();
            panelButtons = new Panel();
            btnExportReport = new Button();
            btnPrint = new Button();
            btnBack = new Button();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelGrades.SuspendLayout();
            panelStats.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(30, 20, 30, 20);
            panelTop.Size = new Size(1000, 80);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "?? Grade Summary Report";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelGrades);
            panelMain.Controls.Add(panelStats);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 520);
            panelMain.TabIndex = 1;
            // 
            // panelGrades
            // 
            panelGrades.BackColor = Color.White;
            panelGrades.BorderStyle = BorderStyle.FixedSingle;
            panelGrades.Controls.Add(txtTopPerformers);
            panelGrades.Controls.Add(lblTopPerformers);
            panelGrades.Controls.Add(txtGradeDistribution);
            panelGrades.Controls.Add(lblGradeDistribution);
            panelGrades.Location = new Point(420, 20);
            panelGrades.Name = "panelGrades";
            panelGrades.Padding = new Padding(20);
            panelGrades.Size = new Size(560, 480);
            panelGrades.TabIndex = 1;
            // 
            // txtTopPerformers
            // 
            txtTopPerformers.BackColor = Color.FromArgb(248, 249, 250);
            txtTopPerformers.BorderStyle = BorderStyle.None;
            txtTopPerformers.Font = new Font("Consolas", 10F);
            txtTopPerformers.Location = new Point(20, 270);
            txtTopPerformers.Multiline = true;
            txtTopPerformers.Name = "txtTopPerformers";
            txtTopPerformers.ReadOnly = true;
            txtTopPerformers.ScrollBars = ScrollBars.Vertical;
            txtTopPerformers.Size = new Size(520, 190);
            txtTopPerformers.TabIndex = 3;
            // 
            // lblTopPerformers
            // 
            lblTopPerformers.AutoSize = true;
            lblTopPerformers.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTopPerformers.ForeColor = Color.FromArgb(52, 58, 64);
            lblTopPerformers.Location = new Point(20, 230);
            lblTopPerformers.Name = "lblTopPerformers";
            lblTopPerformers.Size = new Size(190, 30);
            lblTopPerformers.TabIndex = 2;
            lblTopPerformers.Text = "?? Top Performers";
            // 
            // txtGradeDistribution
            // 
            txtGradeDistribution.BackColor = Color.FromArgb(248, 249, 250);
            txtGradeDistribution.BorderStyle = BorderStyle.None;
            txtGradeDistribution.Font = new Font("Consolas", 10F);
            txtGradeDistribution.Location = new Point(20, 60);
            txtGradeDistribution.Multiline = true;
            txtGradeDistribution.Name = "txtGradeDistribution";
            txtGradeDistribution.ReadOnly = true;
            txtGradeDistribution.ScrollBars = ScrollBars.Vertical;
            txtGradeDistribution.Size = new Size(520, 150);
            txtGradeDistribution.TabIndex = 1;
            // 
            // lblGradeDistribution
            // 
            lblGradeDistribution.AutoSize = true;
            lblGradeDistribution.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGradeDistribution.ForeColor = Color.FromArgb(52, 58, 64);
            lblGradeDistribution.Location = new Point(20, 20);
            lblGradeDistribution.Name = "lblGradeDistribution";
            lblGradeDistribution.Size = new Size(220, 30);
            lblGradeDistribution.TabIndex = 0;
            lblGradeDistribution.Text = "?? Grade Distribution";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.White;
            panelStats.BorderStyle = BorderStyle.FixedSingle;
            panelStats.Controls.Add(lblAvgProject);
            panelStats.Controls.Add(lblAvgAssignment);
            panelStats.Controls.Add(lblAvgOnline);
            panelStats.Controls.Add(lblAvgAttendance);
            panelStats.Controls.Add(lblLowestTotal);
            panelStats.Controls.Add(lblHighestTotal);
            panelStats.Controls.Add(lblAvgTotal);
            panelStats.Controls.Add(lblTotalStudents);
            panelStats.Controls.Add(lblStatsHeader);
            panelStats.Location = new Point(20, 20);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20);
            panelStats.Size = new Size(380, 480);
            panelStats.TabIndex = 0;
            // 
            // lblAvgProject
            // 
            lblAvgProject.AutoSize = true;
            lblAvgProject.Font = new Font("Segoe UI", 9F);
            lblAvgProject.ForeColor = Color.FromArgb(108, 117, 125);
            lblAvgProject.Location = new Point(30, 350);
            lblAvgProject.Name = "lblAvgProject";
            lblAvgProject.Size = new Size(82, 15);
            lblAvgProject.TabIndex = 8;
            lblAvgProject.Text = "?? Avg Project:";
            // 
            // lblAvgAssignment
            // 
            lblAvgAssignment.AutoSize = true;
            lblAvgAssignment.Font = new Font("Segoe UI", 9F);
            lblAvgAssignment.ForeColor = Color.FromArgb(108, 117, 125);
            lblAvgAssignment.Location = new Point(30, 320);
            lblAvgAssignment.Name = "lblAvgAssignment";
            lblAvgAssignment.Size = new Size(104, 15);
            lblAvgAssignment.TabIndex = 7;
            lblAvgAssignment.Text = "?? Avg Assignment:";
            // 
            // lblAvgOnline
            // 
            lblAvgOnline.AutoSize = true;
            lblAvgOnline.Font = new Font("Segoe UI", 9F);
            lblAvgOnline.ForeColor = Color.FromArgb(108, 117, 125);
            lblAvgOnline.Location = new Point(30, 290);
            lblAvgOnline.Name = "lblAvgOnline";
            lblAvgOnline.Size = new Size(76, 15);
            lblAvgOnline.TabIndex = 6;
            lblAvgOnline.Text = "?? Avg Online:";
            // 
            // lblAvgAttendance
            // 
            lblAvgAttendance.AutoSize = true;
            lblAvgAttendance.Font = new Font("Segoe UI", 9F);
            lblAvgAttendance.ForeColor = Color.FromArgb(108, 117, 125);
            lblAvgAttendance.Location = new Point(30, 260);
            lblAvgAttendance.Name = "lblAvgAttendance";
            lblAvgAttendance.Size = new Size(106, 15);
            lblAvgAttendance.TabIndex = 5;
            lblAvgAttendance.Text = "?? Avg Attendance:";
            // 
            // lblLowestTotal
            // 
            lblLowestTotal.AutoSize = true;
            lblLowestTotal.Font = new Font("Segoe UI", 11F);
            lblLowestTotal.ForeColor = Color.FromArgb(220, 53, 69);
            lblLowestTotal.Location = new Point(30, 200);
            lblLowestTotal.Name = "lblLowestTotal";
            lblLowestTotal.Size = new Size(109, 20);
            lblLowestTotal.TabIndex = 4;
            lblLowestTotal.Text = "?? Lowest Total:";
            // 
            // lblHighestTotal
            // 
            lblHighestTotal.AutoSize = true;
            lblHighestTotal.Font = new Font("Segoe UI", 11F);
            lblHighestTotal.ForeColor = Color.FromArgb(40, 167, 69);
            lblHighestTotal.Location = new Point(30, 160);
            lblHighestTotal.Name = "lblHighestTotal";
            lblHighestTotal.Size = new Size(111, 20);
            lblHighestTotal.TabIndex = 3;
            lblHighestTotal.Text = "?? Highest Total:";
            // 
            // lblAvgTotal
            // 
            lblAvgTotal.AutoSize = true;
            lblAvgTotal.Font = new Font("Segoe UI", 11F);
            lblAvgTotal.ForeColor = Color.FromArgb(33, 37, 41);
            lblAvgTotal.Location = new Point(30, 120);
            lblAvgTotal.Name = "lblAvgTotal";
            lblAvgTotal.Size = new Size(108, 20);
            lblAvgTotal.TabIndex = 2;
            lblAvgTotal.Text = "?? Average Total:";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalStudents.ForeColor = Color.FromArgb(33, 37, 41);
            lblTotalStudents.Location = new Point(30, 80);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(124, 20);
            lblTotalStudents.TabIndex = 1;
            lblTotalStudents.Text = "?? Total Students:";
            // 
            // lblStatsHeader
            // 
            lblStatsHeader.AutoSize = true;
            lblStatsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatsHeader.ForeColor = Color.FromArgb(52, 58, 64);
            lblStatsHeader.Location = new Point(20, 20);
            lblStatsHeader.Name = "lblStatsHeader";
            lblStatsHeader.Size = new Size(175, 30);
            lblStatsHeader.TabIndex = 0;
            lblStatsHeader.Text = "?? Statistics";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.BorderStyle = BorderStyle.FixedSingle;
            panelButtons.Controls.Add(btnExportReport);
            panelButtons.Controls.Add(btnPrint);
            panelButtons.Controls.Add(btnBack);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 600);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20, 15, 20, 15);
            panelButtons.Size = new Size(1000, 70);
            panelButtons.TabIndex = 2;
            // 
            // btnExportReport
            // 
            btnExportReport.BackColor = Color.FromArgb(40, 167, 69);
            btnExportReport.FlatAppearance.BorderSize = 0;
            btnExportReport.FlatStyle = FlatStyle.Flat;
            btnExportReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportReport.ForeColor = Color.White;
            btnExportReport.Location = new Point(720, 15);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(140, 40);
            btnExportReport.TabIndex = 2;
            btnExportReport.Text = "?? Export";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(23, 162, 184);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(560, 15);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 40);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "??? Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(108, 117, 125);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "?? Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(1000, 670);
            Controls.Add(panelMain);
            Controls.Add(panelButtons);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grade Summary Report";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelGrades.ResumeLayout(false);
            panelGrades.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblTitle;
        private Panel panelMain;
        private Panel panelStats;
        private Panel panelGrades;
        private Label lblStatsHeader;
        private Label lblTotalStudents;
        private Label lblAvgTotal;
        private Label lblHighestTotal;
        private Label lblLowestTotal;
        private Label lblAvgAttendance;
        private Label lblAvgOnline;
        private Label lblAvgAssignment;
        private Label lblAvgProject;
        private Label lblGradeDistribution;
        private TextBox txtGradeDistribution;
        private Label lblTopPerformers;
        private TextBox txtTopPerformers;
        private Panel panelButtons;
        private Button btnBack;
        private Button btnPrint;
        private Button btnExportReport;
    }
}