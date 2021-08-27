<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607419/18.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4002)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [Data.cs](./CS/Model/Data.cs) (VB: [Data.vb](./VB/Model/Data.vb))
* [MainViewModel.cs](./CS/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/ViewModel/MainViewModel.vb))
<!-- default file list end -->
# How to bind RichEditControl to a text in different formats


<p>This example illustrates how to bind RichEditControl to a text property that may contain different formats (for instance: RTF and HTML).</p><p>To accomplish this task, it is required to use triggers, i.e. DataTrigger, to determine the type of the content and specify a proper descendant of the <a href="http://documentation.devexpress.com/#Silverlight/clsDevExpressXpfRichEditContentToSpecificFormatConvertertopic">ContentToSpecificFormatConverter Class </a> as a correct converter. </p><p><br />
<strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3490">E3490</a><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E2794">E2794</a></p>

<br/>


