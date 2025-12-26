using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.ComponentModel; // для BindingSource
using System.Data; // для DataGridView
using static System.Net.Mime.MediaTypeNames;

partial class MainForm_KhrapkoDD
{
    private System.ComponentModel.IContainer components = null;

    private MenuStrip menuStripMain_KhrapkoDD;
    private ToolStrip toolStrip_KhrapkoDD;
    private DataGridView dataGridViewPCs_KhrapkoDD;
    private BindingSource bindingSourcePCs_KhrapkoDD;
    private ToolStripButton toolStripButtonAdd_KhrapkoDD;
    private ToolStripButton toolStripButtonEdit_KhrapkoDD;
    private ToolStripButton toolStripButtonDelete_KhrapkoDD;
    private ToolStripButton toolStripButtonRefresh_KhrapkoDD;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripLabel toolStripLabelSearch_KhrapkoDD;
    private ToolStripTextBox toolStripTextBoxSearch_KhrapkoDD;
    private ToolStripButton toolStripButtonSearch_KhrapkoDD;
    private ToolStripButton toolStripButtonStats_KhrapkoDD;
    private ToolStripButton toolStripButtonChart_KhrapkoDD;

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        bindingSourcePCs_KhrapkoDD = new BindingSource(components);

        dataGridViewPCs_KhrapkoDD = new DataGridView
        {
            Dock = DockStyle.Fill,
            AllowUserToAddRows = false,
            AutoGenerateColumns = true,
            MultiSelect = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect
        };

        toolStripButtonAdd_KhrapkoDD = new ToolStripButton("Добавить", null, (s, e) => AddPc_KhrapkoDD());
        toolStripButtonEdit_KhrapkoDD = new ToolStripButton("Изменить", null, (s, e) => EditPc_KhrapkoDD());
        toolStripButtonDelete_KhrapkoDD = new ToolStripButton("Удалить", null, (s, e) => DeletePc_KhrapkoDD());
        toolStripButtonRefresh_KhrapkoDD = new ToolStripButton("Обновить", null, (s, e) => LoadDataToGrid_KhrapkoDD());
        toolStripLabelSearch_KhrapkoDD = new ToolStripLabel("Поиск:");
        toolStripTextBoxSearch_KhrapkoDD = new ToolStripTextBox();
        toolStripButtonSearch_KhrapkoDD = new ToolStripButton("Фильтр", null, (s, e) => ApplyFilter_KhrapkoDD());
        toolStripButtonStats_KhrapkoDD = new ToolStripButton("Статистика", null, (s, e) => ShowStats_KhrapkoDD());
        toolStripButtonChart_KhrapkoDD = new ToolStripButton("График", null, (s, e) => ShowChart_KhrapkoDD());

        toolStrip_KhrapkoDD = new ToolStrip
        {
            Items = { toolStripButtonAdd_KhrapkoDD, toolStripButtonEdit_KhrapkoDD,
                      toolStripButtonDelete_KhrapkoDD, toolStripButtonRefresh_KhrapkoDD,
                      toolStripSeparator1,
                      toolStripLabelSearch_KhrapkoDD, toolStripTextBoxSearch_KhrapkoDD, toolStripButtonSearch_KhrapkoDD,
                      new ToolStripSeparator(),
                      toolStripButtonStats_KhrapkoDD, toolStripButtonChart_KhrapkoDD }
        };

        menuStripMain_KhrapkoDD = new MenuStrip();
        var fileMenu = new ToolStripMenuItem("Файл");
        fileMenu.DropDownItems.Add("Выход", null, (s, e) => Close());
        var helpMenu = new ToolStripMenuItem("Справка");
        helpMenu.DropDownItems.Add("О программе", null, (s, e) => new AboutForm_KhrapkoDD().ShowDialog());
        helpMenu.DropDownItems.Add("Руководство", null, (s, e) => new HelpForm_KhrapkoDD().ShowDialog());
        menuStripMain_KhrapkoDD.Items.Add(fileMenu);
        menuStripMain_KhrapkoDD.Items.Add(helpMenu);

        Controls.Add(dataGridViewPCs_KhrapkoDD);
        Controls.Add(toolStrip_KhrapkoDD);
        Controls.Add(menuStripMain_KhrapkoDD);
        MainMenuStrip = menuStripMain_KhrapkoDD;
        Text = "Персональные ЭВМ – Храпко Д.Д.";
        WindowState = FormWindowState.Maximized;
    }
}