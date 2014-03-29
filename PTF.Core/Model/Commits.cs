using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTF.Core.Model
{
    public class Commit
    {
        public string Id { get; set; }
        public string Distinct { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public string Url { get; set; }

        public Author Author { get; set; }
        public Committer Committer { get; set; }

        public List<string> Added { get; set; }
        public List<string> Removed { get; set; }
        public List<string> Modified { get; set; }
    }

    //  "commits": [
    //    {
    //      "id": "9448c109292b4a237b1f49e7495ee27b8c8f2ee7",
    //      "distinct": true,
    //      "message": "proba cseresznye",
    //      "timestamp": "2014-03-21T20:35:58+01:00",
    //      "url": "https://github.com/szasz/Pushing-Task-TestRepo/commit/9448c109292b4a237b1f49e7495ee27b8c8f2ee7",
    //      "author": {
    //        "name": "szasz",
    //        "email": "istvan.szaszko89@gmail.com",
    //        "username": "szasz"
    //      },
    //      "committer": {
    //        "name": "szasz",
    //        "email": "istvan.szaszko89@gmail.com",
    //        "username": "szasz"
    //      },
    //      "added": [

    //      ],
    //      "removed": [

    //      ],
    //      "modified": [
    //        "PushingTaskFollower.v11.suo",
    //        "PushingTaskFollower/Controllers/HomeController.cs",
    //        "PushingTaskFollower/PushingTaskFollower.csproj",
    //        "PushingTaskFollower/bin/PushingTaskFollower.dll",
    //        "PushingTaskFollower/bin/PushingTaskFollower.pdb",
    //        "PushingTaskFollower/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache",
    //        "PushingTaskFollower/obj/Debug/PushingTaskFollower.csprojResolveAssemblyReference.cache",
    //        "PushingTaskFollower/obj/Debug/PushingTaskFollower.dll",
    //        "PushingTaskFollower/obj/Debug/PushingTaskFollower.pdb",
    //        "packages/repositories.config"
    //      ]
    //    }
    //  ],

}
