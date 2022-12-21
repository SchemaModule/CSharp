using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Text.Json;
using System.Net;
using System.Text.RegularExpressions;

namespace Schema.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "SchemaDefinition", HelpUri = "")]
    [OutputType(typeof(Schema.Types.Boolean))]
    [CmdletBinding(PositionalBinding = true)]
    public class NewDefinitionCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        [Parameter(Mandatory = true, Position = 1)]
        public List<string> Required { get; set; } = new List<string>();

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            WriteObject(new Types.Definition()
            {
                Properties = Properties,
                Required = Required
            });
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}