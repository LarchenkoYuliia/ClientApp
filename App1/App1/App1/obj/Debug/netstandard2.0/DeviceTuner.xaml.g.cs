//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("App1.DeviceTuner.xaml", "DeviceTuner.xaml", typeof(global::App1.DeviceTuner))]

namespace App1 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("DeviceTuner.xaml")]
    public partial class DeviceTuner : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ImageButton ImageButtonAddDevice;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Syncfusion.ListView.XForms.SfListView DevicesListView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(DeviceTuner));
            ImageButtonAddDevice = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ImageButton>(this, "ImageButtonAddDevice");
            DevicesListView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.ListView.XForms.SfListView>(this, "DevicesListView");
        }
    }
}