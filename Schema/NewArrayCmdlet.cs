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
    [Cmdlet(VerbsCommon.New, "SchemaArray", HelpUri = "")]
    [OutputType(typeof(Schema.Types.Array))]
    [CmdletBinding(PositionalBinding = true)]
    public class NewArrayCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Id { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string Ref { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string Title { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 4)]
        public string Description { get; set; } = string.Empty;
        [Parameter(Mandatory = false, Position = 5)]
        public List<dynamic> Items { get; set; } = new List<dynamic>();
        [Parameter(Mandatory = false, Position = 6)]
        public bool AdditionalItems { get; set; } = false;
        [Parameter(Mandatory = false, Position = 7)]
        public dynamic Default { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose(Title);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            WriteObject(new Types.Array()
            {
                Id = Id,
                Ref = Ref,
                Title = Title,
                Description = Description,
                Items = Items,
                AdditionalItems = AdditionalItems,
                Default = Default
            });
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}