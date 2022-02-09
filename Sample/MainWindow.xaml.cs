using System.Text;
using Sample.KeyTemplates;
using WPFKeyboard;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            VirtualKeyboard.OnScreenKeyControlBuilder = new SampleKeyControlBuilder();
            VirtualKeyboard.DataContext = new KPDOnScreenKeyboardViewModel();
            StringBuilder locale = new StringBuilder(new string(' ', 256));
            string handle;
            NativeMethods.GetKeyboardLayoutName(locale);
            handle = locale.ToString();
            ((KPDOnScreenKeyboardViewModel)VirtualKeyboard.DataContext).Refresh(KeyboardHelper.InstalledKeyboardLayouts[handle], new ModiferStateManager());
        }
    }
}
