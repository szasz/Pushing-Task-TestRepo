﻿using System;
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

        public Commits Commits { get; set; }
    }
}


//{
//  "ref": "refs/heads/master",
//  "after": "9448c109292b4a237b1f49e7495ee27b8c8f2ee7",
//  "before": "bc9da14d3b88a34357542b3249b5b02ab691f213",
//  "created": false,
//  "deleted": false,
//  "forced": false,
//  "compare": "https://github.com/szasz/Pushing-Task-TestRepo/compare/bc9da14d3b88...9448c109292b",
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
//  "head_commit": {
//    "id": "9448c109292b4a237b1f49e7495ee27b8c8f2ee7",
//    "distinct": true,
//    "message": "proba cseresznye",
//    "timestamp": "2014-03-21T20:35:58+01:00",
//    "url": "https://github.com/szasz/Pushing-Task-TestRepo/commit/9448c109292b4a237b1f49e7495ee27b8c8f2ee7",
//    "author": {
//      "name": "szasz",
//      "email": "istvan.szaszko89@gmail.com",
//      "username": "szasz"
//    },
//    "committer": {
//      "name": "szasz",
//      "email": "istvan.szaszko89@gmail.com",
//      "username": "szasz"
//    },
//    "added": [

//    ],
//    "removed": [

//    ],
//    "modified": [
//      "PushingTaskFollower.v11.suo",
//      "PushingTaskFollower/Controllers/HomeController.cs",
//      "PushingTaskFollower/PushingTaskFollower.csproj",
//      "PushingTaskFollower/bin/PushingTaskFollower.dll",
//      "PushingTaskFollower/bin/PushingTaskFollower.pdb",
//      "PushingTaskFollower/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache",
//      "PushingTaskFollower/obj/Debug/PushingTaskFollower.csprojResolveAssemblyReference.cache",
//      "PushingTaskFollower/obj/Debug/PushingTaskFollower.dll",
//      "PushingTaskFollower/obj/Debug/PushingTaskFollower.pdb",
//      "packages/repositories.config"
//    ]
//  },
//  "repository": {
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
//  "pusher": {
//    "name": "szasz",
//    "email": "szaszdeveloper@outlook.com"
//  }
//}