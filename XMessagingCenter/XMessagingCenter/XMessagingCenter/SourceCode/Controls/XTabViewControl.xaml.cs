using System.Reflection;
using Xamarin.Forms;

namespace XMessagingCenter.SourceCode.Controls
{
    public partial class XTabViewControl : ContentView
    {
        private Assembly _svgAssembly;
        public Assembly SvgAssembly => _svgAssembly ?? (_svgAssembly = typeof(App).GetTypeInfo().Assembly);
        public XTabViewControl()
        {
            InitializeComponent();
        }

        #region TabOne
        public static readonly BindableProperty TabOneItemTemplateProperty =
            BindableProperty.Create<XTabViewControl, DataTemplate>(p => p.TabOneItemTemplate, null, BindingMode.TwoWay, null,
                OnTabOneItemTemplateChanged);

        private static void OnTabOneItemTemplateChanged(BindableObject bindable, DataTemplate oldvalue, DataTemplate newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.TabOnePresenter.ItemTemplate = newvalue;
        }

        public DataTemplate TabOneItemTemplate
        {
            get { return (DataTemplate)GetValue(TabOneItemTemplateProperty); }
            set { SetValue(TabOneItemTemplateProperty, value); }
        }

        public static readonly BindableProperty TabOneLabelProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabOneLabel, string.Empty, BindingMode.TwoWay, null, OnTabOneLabelChanged);

        private static void OnTabOneLabelChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.LabelOne.Text = newvalue;
        }

        public string TabOneLabel
        {
            get { return (string) GetValue(TabOneLabelProperty); }
            set { SetValue(TabOneLabelProperty, value);}
        }


        public static readonly BindableProperty TabOneSvgImageProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabOneLabel, string.Empty, BindingMode.TwoWay, null, OnTabOneSvgImageChanged);

        private static void OnTabOneSvgImageChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            //control.SvgImageOne.SvgPath = newvalue;
        }

        public string TabOneSvgImage
        {
            get { return (string)GetValue(TabOneSvgImageProperty); }
            set { SetValue(TabOneSvgImageProperty, value); }
        }
#endregion

        #region TabTwo
        public static readonly BindableProperty TabTwoItemTemplateProperty =
            BindableProperty.Create<XTabViewControl, DataTemplate>(p => p.TabTwoItemTemplate, null, BindingMode.TwoWay, null,
                OnTabTwoItemTemplateChanged);

        private static void OnTabTwoItemTemplateChanged(BindableObject bindable, DataTemplate oldvalue, DataTemplate newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.TabTwoPresenter.ItemTemplate = newvalue;
        }

        public DataTemplate TabTwoItemTemplate
        {
            get { return (DataTemplate)GetValue(TabTwoItemTemplateProperty); }
            set { SetValue(TabTwoItemTemplateProperty, value); }
        }

        public static readonly BindableProperty TabTwoLabelProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabTwoLabel, string.Empty, BindingMode.TwoWay, null, OnTabTwoLabelChanged);
        private static void OnTabTwoLabelChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.LabelTwo.Text = newvalue;
        }
        public string TabTwoLabel
        {
            get { return (string)GetValue(TabTwoLabelProperty); }
            set { SetValue(TabTwoLabelProperty, value); }
        }

        public static readonly BindableProperty TabTwoSvgImageProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabTwoLabel, string.Empty, BindingMode.TwoWay, null, OnTabTwoSvgImageChanged);

        private static void OnTabTwoSvgImageChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            //control.SvgImageTwo.SvgPath = newvalue;
        }

        public string TabTwoSvgImage
        {
            get { return (string)GetValue(TabTwoSvgImageProperty); }
            set { SetValue(TabTwoSvgImageProperty, value); }
        }

#endregion

        #region TabThree
        public static readonly BindableProperty TabThreeItemTemplateProperty =
            BindableProperty.Create<XTabViewControl, DataTemplate>(p => p.TabThreeItemTemplate, null, BindingMode.TwoWay, null,
                OnTabThreeItemTemplateChanged);

        private static void OnTabThreeItemTemplateChanged(BindableObject bindable, DataTemplate oldvalue, DataTemplate newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.TabThreePresenter.ItemTemplate = newvalue;
        }

        public DataTemplate TabThreeItemTemplate
        {
            get { return (DataTemplate)GetValue(TabThreeItemTemplateProperty); }
            set { SetValue(TabThreeItemTemplateProperty, value); }
        }

        public static readonly BindableProperty TabThreeLabelProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabThreeLabel, string.Empty, BindingMode.TwoWay, null, OnTabThreeLabelChanged);
        private static void OnTabThreeLabelChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            control.LabelThree.Text = newvalue;
        }
        public string TabThreeLabel
        {
            get { return (string)GetValue(TabThreeLabelProperty); }
            set { SetValue(TabThreeLabelProperty, value); }
        }

        public static readonly BindableProperty TabThreeSvgImageProperty =
            BindableProperty.Create<XTabViewControl, string>(p => p.TabThreeLabel, string.Empty, BindingMode.TwoWay, null, OnTabThreeSvgImageChanged);

        private static void OnTabThreeSvgImageChanged(BindableObject bindable, string oldvalue, string newvalue)
        {
            var control = (XTabViewControl)bindable;
            if (control == null) return;
            //control.SvgImageThree.SvgPath = newvalue;
        }

        public string TabThreeSvgImage
        {
            get { return (string)GetValue(TabThreeSvgImageProperty); }
            set { SetValue(TabThreeSvgImageProperty, value); }
        }

#endregion
    }
}
