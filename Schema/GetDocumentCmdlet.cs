using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Text.Json;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks.Dataflow;
using System.Net.Http.Json;
using System.Security.Policy;

namespace Schema.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "SchemaDocument", HelpUri = "")]
    [OutputType(typeof(string))]
    [CmdletBinding(PositionalBinding = true)]
    public class GetDocumentCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Path { get; set; } = string.Empty;
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose(Path);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            Uri Schema = new System.Uri(Path);
            WriteVerbose(Schema.AbsoluteUri);
            WebClient wget = new();
            var json = wget.DownloadString(Schema.AbsoluteUri);
            WriteObject(JsonSerializer.Deserialize<Types.Document>(json));
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}