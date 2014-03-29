using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTF.Core.Model
{
    public class Repository
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Watchers { get; set; }
        public string Stargazers { get; set; }
        public string Forks { get; set; }
        public string Fork { get; set; }
        public string Size { get; set; }

        public Owner Owner { get; set; }

        public string Private { get; set; }
        public string OpenIssues { get; set; }
        public string HasIssues { get; set; }
        public string HasDownloads { get; set; }
        public string HasWiki { get; set; }
        public string Language { get; set; }
        public string CreatedAt { get; set; }
        public string PushedAt { get; set; }
        public string MasterBranch { get; set; }
    }

    //"repository": {
//    "id": 17404655,
//    "name": "Pushing-Task-TestRepo",
//    "url": "https://github.com/szasz/Pushing-Task-TestRepo",
//    "description": "This is a test repo with github push to appharbor.",
//    "watchers": 0,
//    "stargazers": 0,
//    "forks": 0,
//    "fork": false,
//    "size": 17300,
//    "owner": {
//      "name": "szasz",
//      "email": "szaszdeveloper@outlook.com"
//    },
//    "private": false,
//    "open_issues": 0,
//    "has_issues": true,

//    "has_downloads": true,
//    "has_wiki": true,
//    "language": "JavaScript",
//    "created_at": 1393942836,
//    "pushed_at": 1395430583,
//    "master_branch": "master"
//  },
}
