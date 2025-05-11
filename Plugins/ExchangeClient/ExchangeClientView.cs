using MemoriaToolsInterfaces;
using System;
using System.Windows.Forms;

namespace ExchangeClient
{
    public partial class ExchangeClientView : UserControl, IPluginView
    {
        public ExchangeClientView()
        {
            InitializeComponent();
        }

        public string Title => "Exchange Client";
        public string ButtonName => "Exchange Client";
        public event EventHandler<ViewEventArgs> OnLogRequested;

        public void Initialize()
        {
            var args = new ViewEventArgs();
            args.Message = "Exchange Client Initialized";
            OnLogRequested?.Invoke(this, args);
        }


    }
}
