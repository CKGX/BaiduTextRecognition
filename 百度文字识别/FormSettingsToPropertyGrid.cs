using System;
using System.Configuration;
using System.Windows.Forms;

namespace 百度文字识别
{
    /// <summary>
    /// <para>基于“PropertyGrid”的简单处理程序配置，它的好处是可以处理复杂的对象，但使用的时候配置也更复杂。</para>
    /// <para>当前要求使用C#中的配置对象是“Settings.Default”，这个对象由项目的“属性”中的“设置”中配置，配置好后自动生成，然后修改对象文件。</para>
    /// <para>简单的使用见：https://www.cnblogs.com/code1992/p/10197021.html"</para>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormSettingsToPropertyGrid : Form
    {
        private readonly ApplicationSettingsBase _applicationSettingsBase = null;

        /// <summary>
        /// 是否在窗体关闭时自动保存
        /// </summary>
        /// <value>
        ///   true：保存
        /// </value>
        public bool AutoSave => true;

        /// <summary>
        /// 基于<see cref="PropertyGrid"/>组件创建程序配置文件
        /// </summary>
        /// <param name="applicationSettingsBase">The application settings base.</param>
        public FormSettingsToPropertyGrid(ApplicationSettingsBase applicationSettingsBase)
        {
            InitializeComponent();
            propertyGridMain.SelectedObject = applicationSettingsBase;
            _applicationSettingsBase = applicationSettingsBase;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            _applicationSettingsBase.Reload();
        }

        private void CkFormSimpleSettings_Load(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _applicationSettingsBase.Save();
        }

        private void CkFormSettingsToPropertyGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AutoSave)
            {
                _applicationSettingsBase.Save();
            }
        }
    }
}