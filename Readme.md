# How to generate a live report based on GridControl content


<p>This example demonstrates how to use the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument12387">Snap Control</a> facilities to generate an "editable" report based on GridControl content.<br />The SnapControl provides a corresponding API to generate a SnapDocument layout at runtime, including creating master-detail lists, grouping, sorting, etc. <br /><a href="https://www.devexpress.com/Support/Center/p/E4781">How to generate a document layout in code via the Snap application programming interface (API)</a><br /><br />The main benefit of using the SnapControl component to generate GridControl's report is that an end-user operates with a <strong>"live" editable document</strong>, whose layout can be customized like a <strong>regular Word document</strong>, and all changes made in a document layout are immediately applied to current report content (report data).</p>
<p><br />To build the solution demonstrated in this sample into an existing application, copy the "<strong>SnapReportForGridGenerator</strong>" and "<strong>SnapReportFormGenerator</strong>" files into your project and use a corresponding extension method to generate a Snap report for current GridControl data:</p>


```cs
gridControl1.ShowSnapReportPreviewForm();

```


<p>Take special note that this approach requires adding <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument12298">corresponding assemblies</a> into your project.</p>
<p>The following video demonstrates how to customize a generated SnapDocument at runtime, save all changes made at runtime in the SNX format and restore them on further generating a report:<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-a-live-report-based-on-gridcontrol-content-t272175/15.1.5+/media/227b2b5a-3539-11e5-80bf-00155d62480c.png"></p>
<p>An extended version of this video (which also demonstrates how to display headers for each master row) is available (is built-in) in C# and VB solutions of this example (the "Snap_Report_Customization.swf" file).<br />A key point is that any changes made in the SnapDocument affect only a current record template. To apply the changes for a whole document, you need to force updating all SnapList records in the document. <br />The simplest solution to achieve this is to click a record next to the currently edited one.</p>
<p>P.S. This approach has the following limitations:<br />1. In case of a large amount of data (a large number of records in the GirdControl view), there can be performance issues on rendering and calculating the layout of the SnapControl document.<br />2. The SnapControl does not support <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument8398">Server Mode</a> data sources.</p>

<br/>


