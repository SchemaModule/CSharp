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
using System.IO;

namespace Schema.Cmdlets
{
    [Cmdlet(VerbsData.ConvertTo, "SchemaElement", HelpUri = "")]
    [OutputType(typeof(Schema.Types.Document))]
    [CmdletBinding(PositionalBinding = true)]
    public class ConvertToElementCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public dynamic Schema { get; set; }
        [Parameter(Mandatory = false, Position = 1)]
        public SwitchParameter IsRootSchema { get; set; } = true;
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            //WriteVerbose(Schema);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            string Type = Schema.GetType().Name;
            WriteVerbose(Type);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }

}