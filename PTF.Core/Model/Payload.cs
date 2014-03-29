using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTF.Core.Model
{
    public class Payload
    {
        public string Ref { get; set; }
        public string After { get; set; }
        public string Before { get; set; }
        public string Created { get; set; }
        public string Deleted { get; set; }
        public string Forced { get; set; }
        public string Compare { get; set; }

		/// <summary>
		/// A commitok listájával tér vissza.
		/// </summary>
        public IEnumerable<Commit> Commits { get; set; }

        /// <summary>
        /// A head_commit-tal tér vissza
        /// </summary>
        public Commit HeadCommit { get; set; }

        public Repository Repository { get; set; }
    }
}