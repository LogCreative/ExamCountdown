<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑誓言EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.锁定誓言LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.新建NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.定时关闭EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.多媒体MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.窗口WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.位置PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左上角ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右上角ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左下角ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右下角ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.大小SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最小SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.中ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.宣言TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.自定义OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤销UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重做RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.格式OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.颜色CToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.置于顶层TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDayChn = New System.Windows.Forms.Label()
        Me.LabelDayEng = New System.Windows.Forms.Label()
        Me.LabelDay = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelHourEng = New System.Windows.Forms.Label()
        Me.LabelSecEng = New System.Windows.Forms.Label()
        Me.LabelSecChn = New System.Windows.Forms.Label()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.LabelMinEng = New System.Windows.Forms.Label()
        Me.LabelMinChn = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelHourChn = New System.Windows.Forms.Label()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.RichTextBoxSaying = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialogBox = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialogTime = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogTime2 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelLock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelSave = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelByte = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelTimeup = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.新功能NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.窗口WToolStripMenuItem, Me.编辑EToolStripMenuItem, Me.格式OToolStripMenuItem, Me.设置SToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(386, 25)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.编辑誓言EToolStripMenuItem, Me.锁定誓言LToolStripMenuItem, Me.ToolStripSeparator4, Me.新建NToolStripMenuItem, Me.打开OToolStripMenuItem, Me.保存SToolStripMenuItem, Me.ToolStripSeparator1, Me.定时关闭EToolStripMenuItem, Me.ToolStripSeparator3, Me.多媒体MToolStripMenuItem, Me.ToolStripSeparator7, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '编辑誓言EToolStripMenuItem
        '
        Me.编辑誓言EToolStripMenuItem.Image = CType(resources.GetObject("编辑誓言EToolStripMenuItem.Image"), System.Drawing.Image)
        Me.编辑誓言EToolStripMenuItem.Name = "编辑誓言EToolStripMenuItem"
        Me.编辑誓言EToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.编辑誓言EToolStripMenuItem.Text = "编辑 宣言(&E)"
        '
        '锁定誓言LToolStripMenuItem
        '
        Me.锁定誓言LToolStripMenuItem.Enabled = False
        Me.锁定誓言LToolStripMenuItem.Image = CType(resources.GetObject("锁定誓言LToolStripMenuItem.Image"), System.Drawing.Image)
        Me.锁定誓言LToolStripMenuItem.Name = "锁定誓言LToolStripMenuItem"
        Me.锁定誓言LToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.锁定誓言LToolStripMenuItem.Text = "锁定 宣言(&L)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(162, 6)
        '
        '新建NToolStripMenuItem
        '
        Me.新建NToolStripMenuItem.Enabled = False
        Me.新建NToolStripMenuItem.Image = CType(resources.GetObject("新建NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem"
        Me.新建NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新建NToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.新建NToolStripMenuItem.Text = "新建(&N)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Image = CType(resources.GetObject("打开OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Enabled = False
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        '定时关闭EToolStripMenuItem
        '
        Me.定时关闭EToolStripMenuItem.Image = CType(resources.GetObject("定时关闭EToolStripMenuItem.Image"), System.Drawing.Image)
        Me.定时关闭EToolStripMenuItem.Name = "定时关闭EToolStripMenuItem"
        Me.定时关闭EToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.定时关闭EToolStripMenuItem.Text = "定时关闭(&E)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        '多媒体MToolStripMenuItem
        '
        Me.多媒体MToolStripMenuItem.Image = CType(resources.GetObject("多媒体MToolStripMenuItem.Image"), System.Drawing.Image)
        Me.多媒体MToolStripMenuItem.Name = "多媒体MToolStripMenuItem"
        Me.多媒体MToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.多媒体MToolStripMenuItem.Text = "多媒体(&M)"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(162, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Image = CType(resources.GetObject("退出XToolStripMenuItem.Image"), System.Drawing.Image)
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '窗口WToolStripMenuItem
        '
        Me.窗口WToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.位置PToolStripMenuItem, Me.大小SToolStripMenuItem, Me.ToolStripSeparator5, Me.自定义OToolStripMenuItem})
        Me.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem"
        Me.窗口WToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.窗口WToolStripMenuItem.Text = "窗口(&W)"
        '
        '位置PToolStripMenuItem
        '
        Me.位置PToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.左上角ToolStripMenuItem, Me.右上角ToolStripMenuItem, Me.左下角ToolStripMenuItem, Me.右下角ToolStripMenuItem})
        Me.位置PToolStripMenuItem.Name = "位置PToolStripMenuItem"
        Me.位置PToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.位置PToolStripMenuItem.Text = "位置(&P)"
        '
        '左上角ToolStripMenuItem
        '
        Me.左上角ToolStripMenuItem.Name = "左上角ToolStripMenuItem"
        Me.左上角ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.左上角ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.左上角ToolStripMenuItem.Text = "左上角"
        '
        '右上角ToolStripMenuItem
        '
        Me.右上角ToolStripMenuItem.Name = "右上角ToolStripMenuItem"
        Me.右上角ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.右上角ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.右上角ToolStripMenuItem.Text = "右上角"
        '
        '左下角ToolStripMenuItem
        '
        Me.左下角ToolStripMenuItem.Name = "左下角ToolStripMenuItem"
        Me.左下角ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.左下角ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.左下角ToolStripMenuItem.Text = "左下角"
        '
        '右下角ToolStripMenuItem
        '
        Me.右下角ToolStripMenuItem.Name = "右下角ToolStripMenuItem"
        Me.右下角ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.右下角ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.右下角ToolStripMenuItem.Text = "右下角"
        '
        '大小SToolStripMenuItem
        '
        Me.大小SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.最小SToolStripMenuItem, Me.ToolStripMenuItem1, Me.中ToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator8, Me.宣言TToolStripMenuItem})
        Me.大小SToolStripMenuItem.Name = "大小SToolStripMenuItem"
        Me.大小SToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.大小SToolStripMenuItem.Text = "大小(&S)"
        '
        '最小SToolStripMenuItem
        '
        Me.最小SToolStripMenuItem.Name = "最小SToolStripMenuItem"
        Me.最小SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.最小SToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.最小SToolStripMenuItem.Text = "最小(&S)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem1.Text = "小(&L)"
        '
        '中ToolStripMenuItem
        '
        Me.中ToolStripMenuItem.Name = "中ToolStripMenuItem"
        Me.中ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D7), System.Windows.Forms.Keys)
        Me.中ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.中ToolStripMenuItem.Text = "中(&M)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D8), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem2.Text = "大(&B)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(156, 6)
        '
        '宣言TToolStripMenuItem
        '
        Me.宣言TToolStripMenuItem.Name = "宣言TToolStripMenuItem"
        Me.宣言TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D9), System.Windows.Forms.Keys)
        Me.宣言TToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.宣言TToolStripMenuItem.Text = "宣言(&T)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(127, 6)
        '
        '自定义OToolStripMenuItem
        '
        Me.自定义OToolStripMenuItem.Name = "自定义OToolStripMenuItem"
        Me.自定义OToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.自定义OToolStripMenuItem.Text = "自定义(&O)"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤销UToolStripMenuItem, Me.重做RToolStripMenuItem, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.删除DToolStripMenuItem, Me.全选AToolStripMenuItem})
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.编辑EToolStripMenuItem.Text = "编辑(&E)"
        Me.编辑EToolStripMenuItem.Visible = False
        '
        '撤销UToolStripMenuItem
        '
        Me.撤销UToolStripMenuItem.Image = CType(resources.GetObject("撤销UToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤销UToolStripMenuItem.Name = "撤销UToolStripMenuItem"
        Me.撤销UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤销UToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.撤销UToolStripMenuItem.Text = "撤销(&U)"
        '
        '重做RToolStripMenuItem
        '
        Me.重做RToolStripMenuItem.Image = CType(resources.GetObject("重做RToolStripMenuItem.Image"), System.Drawing.Image)
        Me.重做RToolStripMenuItem.Name = "重做RToolStripMenuItem"
        Me.重做RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重做RToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.重做RToolStripMenuItem.Text = "重做(&R)"
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        '删除DToolStripMenuItem
        '
        Me.删除DToolStripMenuItem.Image = CType(resources.GetObject("删除DToolStripMenuItem.Image"), System.Drawing.Image)
        Me.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem"
        Me.删除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.删除DToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.删除DToolStripMenuItem.Text = "删除(&D)"
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        '格式OToolStripMenuItem
        '
        Me.格式OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体FToolStripMenuItem, Me.颜色CToolStripMenuItem1})
        Me.格式OToolStripMenuItem.Name = "格式OToolStripMenuItem"
        Me.格式OToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.格式OToolStripMenuItem.Text = "格式(&O)"
        Me.格式OToolStripMenuItem.Visible = False
        '
        '字体FToolStripMenuItem
        '
        Me.字体FToolStripMenuItem.Image = CType(resources.GetObject("字体FToolStripMenuItem.Image"), System.Drawing.Image)
        Me.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem"
        Me.字体FToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.字体FToolStripMenuItem.Text = "字体(&F)"
        '
        '颜色CToolStripMenuItem1
        '
        Me.颜色CToolStripMenuItem1.Image = CType(resources.GetObject("颜色CToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.颜色CToolStripMenuItem1.Name = "颜色CToolStripMenuItem1"
        Me.颜色CToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.颜色CToolStripMenuItem1.Text = "颜色(&C)"
        '
        '设置SToolStripMenuItem
        '
        Me.设置SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设置OToolStripMenuItem, Me.ToolStripSeparator6, Me.置于顶层TToolStripMenuItem})
        Me.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem"
        Me.设置SToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.设置SToolStripMenuItem.Text = "设置(&S)"
        '
        '设置OToolStripMenuItem
        '
        Me.设置OToolStripMenuItem.Image = CType(resources.GetObject("设置OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.设置OToolStripMenuItem.Name = "设置OToolStripMenuItem"
        Me.设置OToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.设置OToolStripMenuItem.Text = "设置(&O)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        '置于顶层TToolStripMenuItem
        '
        Me.置于顶层TToolStripMenuItem.CheckOnClick = True
        Me.置于顶层TToolStripMenuItem.Image = CType(resources.GetObject("置于顶层TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.置于顶层TToolStripMenuItem.Name = "置于顶层TToolStripMenuItem"
        Me.置于顶层TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.置于顶层TToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.置于顶层TToolStripMenuItem.Text = "置于顶层(&T)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.帮助HToolStripMenuItem1, Me.新功能NToolStripMenuItem, Me.ToolStripSeparator2, Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '帮助HToolStripMenuItem1
        '
        Me.帮助HToolStripMenuItem1.Image = CType(resources.GetObject("帮助HToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1"
        Me.帮助HToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.帮助HToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.帮助HToolStripMenuItem1.Text = "帮助(&H)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Image = CType(resources.GetObject("关于AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.关于AToolStripMenuItem.Text = "关于 中考倒计(&A)"
        '
        'LabelDayChn
        '
        Me.LabelDayChn.AutoSize = True
        Me.LabelDayChn.BackColor = System.Drawing.Color.Transparent
        Me.LabelDayChn.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.LabelDayChn.ForeColor = System.Drawing.Color.Black
        Me.LabelDayChn.Location = New System.Drawing.Point(192, 54)
        Me.LabelDayChn.Name = "LabelDayChn"
        Me.LabelDayChn.Size = New System.Drawing.Size(42, 35)
        Me.LabelDayChn.TabIndex = 2
        Me.LabelDayChn.Text = "天"
        '
        'LabelDayEng
        '
        Me.LabelDayEng.AutoSize = True
        Me.LabelDayEng.BackColor = System.Drawing.Color.Transparent
        Me.LabelDayEng.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!)
        Me.LabelDayEng.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelDayEng.Location = New System.Drawing.Point(192, 89)
        Me.LabelDayEng.Name = "LabelDayEng"
        Me.LabelDayEng.Size = New System.Drawing.Size(42, 21)
        Me.LabelDayEng.TabIndex = 3
        Me.LabelDayEng.Text = "DAY"
        '
        'LabelDay
        '
        Me.LabelDay.AutoSize = True
        Me.LabelDay.BackColor = System.Drawing.Color.Transparent
        Me.LabelDay.Font = New System.Drawing.Font("微软雅黑", 35.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDay.ForeColor = System.Drawing.Color.Red
        Me.LabelDay.Location = New System.Drawing.Point(66, 51)
        Me.LabelDay.Name = "LabelDay"
        Me.LabelDay.Size = New System.Drawing.Size(114, 62)
        Me.LabelDay.TabIndex = 1
        Me.LabelDay.Text = "999"
        Me.LabelDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.LabelTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelTitle.Location = New System.Drawing.Point(89, 17)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(132, 27)
        Me.LabelTitle.TabIndex = 13
        Me.LabelTitle.Text = "距离中考还有"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.LabelHourEng)
        Me.GroupBox1.Controls.Add(Me.LabelSecEng)
        Me.GroupBox1.Controls.Add(Me.LabelTitle)
        Me.GroupBox1.Controls.Add(Me.LabelSecChn)
        Me.GroupBox1.Controls.Add(Me.LabelDayEng)
        Me.GroupBox1.Controls.Add(Me.LabelSec)
        Me.GroupBox1.Controls.Add(Me.LabelDayChn)
        Me.GroupBox1.Controls.Add(Me.LabelMinEng)
        Me.GroupBox1.Controls.Add(Me.LabelDay)
        Me.GroupBox1.Controls.Add(Me.LabelMinChn)
        Me.GroupBox1.Controls.Add(Me.LabelMin)
        Me.GroupBox1.Controls.Add(Me.LabelHourChn)
        Me.GroupBox1.Controls.Add(Me.LabelHour)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 681)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "计时器"
        '
        'LabelHourEng
        '
        Me.LabelHourEng.AutoSize = True
        Me.LabelHourEng.BackColor = System.Drawing.Color.Transparent
        Me.LabelHourEng.Font = New System.Drawing.Font("微软雅黑 Light", 8.0!)
        Me.LabelHourEng.Location = New System.Drawing.Point(70, 151)
        Me.LabelHourEng.Name = "LabelHourEng"
        Me.LabelHourEng.Size = New System.Drawing.Size(40, 16)
        Me.LabelHourEng.TabIndex = 30
        Me.LabelHourEng.Text = "HOUR"
        '
        'LabelSecEng
        '
        Me.LabelSecEng.AutoSize = True
        Me.LabelSecEng.BackColor = System.Drawing.Color.Transparent
        Me.LabelSecEng.Font = New System.Drawing.Font("微软雅黑 Light", 8.0!)
        Me.LabelSecEng.Location = New System.Drawing.Point(272, 151)
        Me.LabelSecEng.Name = "LabelSecEng"
        Me.LabelSecEng.Size = New System.Drawing.Size(52, 16)
        Me.LabelSecEng.TabIndex = 37
        Me.LabelSecEng.Text = "SECOND"
        '
        'LabelSecChn
        '
        Me.LabelSecChn.AutoSize = True
        Me.LabelSecChn.BackColor = System.Drawing.Color.Transparent
        Me.LabelSecChn.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.LabelSecChn.Location = New System.Drawing.Point(282, 124)
        Me.LabelSecChn.Name = "LabelSecChn"
        Me.LabelSecChn.Size = New System.Drawing.Size(32, 27)
        Me.LabelSecChn.TabIndex = 36
        Me.LabelSecChn.Text = "秒"
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.BackColor = System.Drawing.Color.Transparent
        Me.LabelSec.Font = New System.Drawing.Font("微软雅黑", 22.0!)
        Me.LabelSec.ForeColor = System.Drawing.Color.Blue
        Me.LabelSec.Location = New System.Drawing.Point(220, 124)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.Size = New System.Drawing.Size(53, 39)
        Me.LabelSec.TabIndex = 35
        Me.LabelSec.Text = "59"
        Me.LabelSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMinEng
        '
        Me.LabelMinEng.AutoSize = True
        Me.LabelMinEng.BackColor = System.Drawing.Color.Transparent
        Me.LabelMinEng.Font = New System.Drawing.Font("微软雅黑 Light", 8.0!)
        Me.LabelMinEng.Location = New System.Drawing.Point(165, 151)
        Me.LabelMinEng.Name = "LabelMinEng"
        Me.LabelMinEng.Size = New System.Drawing.Size(49, 16)
        Me.LabelMinEng.TabIndex = 34
        Me.LabelMinEng.Text = "MINUTE"
        '
        'LabelMinChn
        '
        Me.LabelMinChn.AutoSize = True
        Me.LabelMinChn.BackColor = System.Drawing.Color.Transparent
        Me.LabelMinChn.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.LabelMinChn.Location = New System.Drawing.Point(173, 124)
        Me.LabelMinChn.Name = "LabelMinChn"
        Me.LabelMinChn.Size = New System.Drawing.Size(32, 27)
        Me.LabelMinChn.TabIndex = 33
        Me.LabelMinChn.Text = "分"
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.BackColor = System.Drawing.Color.Transparent
        Me.LabelMin.Font = New System.Drawing.Font("微软雅黑", 22.0!)
        Me.LabelMin.ForeColor = System.Drawing.Color.Blue
        Me.LabelMin.Location = New System.Drawing.Point(112, 124)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(53, 39)
        Me.LabelMin.TabIndex = 32
        Me.LabelMin.Text = "59"
        Me.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelHourChn
        '
        Me.LabelHourChn.AutoSize = True
        Me.LabelHourChn.BackColor = System.Drawing.Color.Transparent
        Me.LabelHourChn.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.LabelHourChn.ForeColor = System.Drawing.Color.Black
        Me.LabelHourChn.Location = New System.Drawing.Point(74, 124)
        Me.LabelHourChn.Name = "LabelHourChn"
        Me.LabelHourChn.Size = New System.Drawing.Size(32, 27)
        Me.LabelHourChn.TabIndex = 29
        Me.LabelHourChn.Text = "时"
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelHour.Font = New System.Drawing.Font("微软雅黑", 22.0!)
        Me.LabelHour.ForeColor = System.Drawing.Color.Blue
        Me.LabelHour.Location = New System.Drawing.Point(16, 124)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(53, 39)
        Me.LabelHour.TabIndex = 31
        Me.LabelHour.Text = "23"
        Me.LabelHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RichTextBoxSaying
        '
        Me.RichTextBoxSaying.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBoxSaying.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxSaying.Location = New System.Drawing.Point(13, 22)
        Me.RichTextBoxSaying.Name = "RichTextBoxSaying"
        Me.RichTextBoxSaying.ReadOnly = True
        Me.RichTextBoxSaying.Size = New System.Drawing.Size(640, 702)
        Me.RichTextBoxSaying.TabIndex = 25
        Me.RichTextBoxSaying.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBoxSaying)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(600, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 681)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "班级宣言"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelTime, Me.LabelSize, Me.LabelLock, Me.LabelSave, Me.LabelByte})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 229)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(386, 22)
        Me.StatusStrip1.TabIndex = 27
        '
        'LabelTime
        '
        Me.LabelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(32, 17)
        Me.LabelTime.Text = "就绪"
        '
        'LabelSize
        '
        Me.LabelSize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSize.Image = CType(resources.GetObject("LabelSize.Image"), System.Drawing.Image)
        Me.LabelSize.Margin = New System.Windows.Forms.Padding(100, 3, 0, 2)
        Me.LabelSize.Name = "LabelSize"
        Me.LabelSize.Size = New System.Drawing.Size(48, 17)
        Me.LabelSize.Text = "加载"
        '
        'LabelLock
        '
        Me.LabelLock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLock.Margin = New System.Windows.Forms.Padding(300, 3, 0, 2)
        Me.LabelLock.Name = "LabelLock"
        Me.LabelLock.Size = New System.Drawing.Size(44, 17)
        Me.LabelLock.Text = "已锁定"
        '
        'LabelSave
        '
        Me.LabelSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSave.Name = "LabelSave"
        Me.LabelSave.Size = New System.Drawing.Size(44, 17)
        Me.LabelSave.Text = "已保存"
        Me.LabelSave.Visible = False
        '
        'LabelByte
        '
        Me.LabelByte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelByte.Name = "LabelByte"
        Me.LabelByte.Size = New System.Drawing.Size(63, 17)
        Me.LabelByte.Text = "字符数：0"
        Me.LabelByte.Visible = False
        '
        'LabelTimeup
        '
        Me.LabelTimeup.AutoSize = True
        Me.LabelTimeup.Location = New System.Drawing.Point(6, 669)
        Me.LabelTimeup.Name = "LabelTimeup"
        Me.LabelTimeup.Size = New System.Drawing.Size(41, 12)
        Me.LabelTimeup.TabIndex = 28
        Me.LabelTimeup.Text = "Label1"
        Me.LabelTimeup.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 12)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "0"
        Me.Label8.Visible = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(178, 25)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(113, 12)
        Me.LabelDate.TabIndex = 31
        Me.LabelDate.Text = "2015-6-14 08:00:00"
        Me.LabelDate.Visible = False
        '
        '新功能NToolStripMenuItem
        '
        Me.新功能NToolStripMenuItem.Image = CType(resources.GetObject("新功能NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新功能NToolStripMenuItem.Name = "新功能NToolStripMenuItem"
        Me.新功能NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.新功能NToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.新功能NToolStripMenuItem.Text = "新功能(&N)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(386, 251)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelTimeup)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "Form1"
        Me.Text = "中考倒计"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelDayChn As System.Windows.Forms.Label
    Friend WithEvents LabelDayEng As System.Windows.Forms.Label
    Friend WithEvents LabelDay As System.Windows.Forms.Label
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBoxSaying As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents 编辑誓言EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 锁定誓言LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 格式OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字体FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 颜色CToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 撤销UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重做RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialogBox As System.Windows.Forms.ColorDialog
    Friend WithEvents LabelSecEng As System.Windows.Forms.Label
    Friend WithEvents LabelSecChn As System.Windows.Forms.Label
    Friend WithEvents LabelSec As System.Windows.Forms.Label
    Friend WithEvents LabelMinEng As System.Windows.Forms.Label
    Friend WithEvents LabelMinChn As System.Windows.Forms.Label
    Friend WithEvents LabelMin As System.Windows.Forms.Label
    Friend WithEvents LabelHourChn As System.Windows.Forms.Label
    Friend WithEvents LabelHour As System.Windows.Forms.Label
    Friend WithEvents LabelHourEng As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColorDialogTime As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialogTime2 As System.Windows.Forms.ColorDialog
    Friend WithEvents 新建NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents 置于顶层TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents 帮助HToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelTimeup As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents 定时关闭EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LabelLock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelSave As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelByte As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents 窗口WToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 位置PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 左上角ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 右上角ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 左下角ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 右下角ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 大小SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 最小SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 中ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 宣言TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 自定义OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 多媒体MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 新功能NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
