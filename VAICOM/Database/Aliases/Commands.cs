﻿using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Aliases
        {

            public static Dictionary<string, string> aicommands = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "My Target",              "mytarget"              },
                { "My Contact",             "mytarget"              },
                { "Bandit*",                "bandit"                },
                { "Bogey*",                 "bandit"                },
                { "Outlaw*",                "bandit"                },
                { "Hostile*",               "bandit"                },
                { "Ground Target*",         "groundtarget"          },
                { "Group",                  "groundtarget"          },
                { "Armor",                  "armor"                 },
                { "Tanks",                  "armor"                 },
                { "Movers",                 "armor"                 },
                { "Column",                 "armor"                 },
                { "Artillery",              "artillery"             },
                { "Air Defense*",           "airdefense"            },
                { "AAA",                    "airdefense"            },
                { "SAM*",                   "airdefense"            },
                { "Utility*",               "utility"               },
                { "Vehicles",               "utility"               },
                { "Trucks",                 "utility"               },
                { "Infantry",               "infantry"              },
                { "Soldiers",               "infantry"              },
                { "Troops",                 "infantry"              },
                { "Ship*",                  "ship"                  },
                { "Vessel*",                "ship"                  },
                { "Skunk*",                 "ship"                  },
                { "D-link Target",          "dlinktarget"           },
                { "D-link Targets",         "dlinktargets"          },
                { "D-link Target by Type",  "dlinktargetbytype"     },
                { "D-link Targets by Type", "dlinktargetsbytype"    },
                { "Complete and Rejoin",    "completeandrejoin"     },
                { "Complete and RTB",       "completeandrtb"        },
                { "Ray Target",             "raytarget"             },
                { "My Enemy",               "myenemy"               },
                { "Clear my Six",           "myenemy"               },
                { "Cover Me",               "coverme"               },
                { "Radio Check",            "flightcheckin"         },
                { "Heads Up",               "flightcheckin"         },
                { "Pincer Right",           "pincerright"           },
                { "Pincer Left",            "pincerleft"            },
                { "Pincer High",            "pincerhigh"            },
                { "Pincer Low",             "pincerlow"             },
                { "Break Right",            "breakright"            },
                { "Break Left",             "breakleft"             },
                { "Break High",             "breakhigh"             },
                { "Break Low",              "breaklow"              },
                { "Clear Right",            "clearright"            },
                { "Clear Starboard",        "clearright"            },
                { "Clear Left",             "clearleft"             },
                { "Clear Port",             "clearleft"             },
                { "Pump",                   "pump"                  },
                { "Anchor Here",            "anchorhere"            },
                { "Hold Position",          "anchorhere"            },
                { "Reference My Steerpoint","anchoratsteerpoint"    },
                { "Reference My Spee",      "anchoratspi"           },
                { "Reference Point",        "anchoratpoint"         },
                { "Return To Base",         "returntobase"          },
                { "Go Home",                "returntobase"          },
                { "RTB",                    "returntobase"          },
                { "Go to Tanker",           "flytotanker"           },
                { "*Join*",                 "joinup"                },
                { "Fly Route",              "flyroute"              },
                { "Continue",               "flyroute"              },
                { "Kick out to 1 mile",     "makerecon1"            },
                { "Kick out to 2 miles",    "makerecon2"            },
                { "Kick out to 3 miles",    "makerecon3"            },
                { "Kick out to 5 miles",    "makerecon5"            },
                { "Kick out to 8 miles",    "makerecon8"            },
                { "Kick out to 10 miles",   "makerecon10"           },
                { "Check my Spee",          "makereconatpoint"      },
                { "Radar On",               "radaron"               },
                { "Radar Off",              "radaroff"              },
                { "ECM On",                 "ecmon"                 },
                { "Music On",               "ecmon"                 },
                { "ECM Off",                "ecmoff"                },
                { "Music Off",              "ecmoff"                },
                { "Smoke On",               "smokeon"               },
                { "Smoke Off",              "smokeoff"              },
                { "Jettison Stores",        "jettisonweapons"       },
                { "Fence In",               "fencein"               },
                { "Fence Out",              "fenceout"              },
                { "Out Cold",               "out"                   },
                { "Go Line Abreast",        "golineabreast"         },
                { "Go Trail",               "gotrail"               },
                { "Go Wedge",               "gowedge"               },
                { "Go Echelon Right",       "goechelonright"        },
                { "Go Starboard",           "goechelonright"        },
                { "Go Echelon Left",        "goechelonleft"         },
                { "Go Port",                "goechelonleft"         },
                { "Go Finger Four",         "gofingerfour"          },
                { "Go Spread Four",         "gospreadfour"          },
                { "Close Formation",        "closeformation"        },
                { "Close Up",               "closeformation"        },
                { "Move Closer",            "closeformation"        },
                { "Keep It Tight",          "closeformation"        },
                { "Open Formation",         "openformation"         },
                { "Open Up",                "openformation"         },
                { "Go Wide",                "openformation"         },
                { "Spread Out",             "openformation"         },
                { "Close Group",            "closegroupformation"   },
                { "Go Heavy",               "helogoheavy"           },
                { "Helos go Echelon",       "helogoechelon"         },
                { "Helos go Spread",        "helogospread"          },
                { "Helos go Trail",         "helogotrail"           },
                { "Go Overwatch",           "helogooverwatch"       },
                { "Go Helo Left",           "helogoleft"            },
                { "Go Helo Right",          "helogoright"           },
                { "Go Helo Tight",          "helogotight"           },
                { "Go Cruise",              "helogocruise"          },
                { "Go Combat",              "helogocombat"          },
                { "Request Engines Start",  "requestenginesstart"   },
                { "Request Startup",        "requestenginesstart"   },
                { "Request Hover",          "requesthover"          },
                { "Request Taxi to Runway", "requesttaxitorunway"   },
                { "Request Takeoff",        "requesttakeoff"        },
                { "Request Departure",      "requesttakeoff"        },
                { "Ready for Takeoff",      "requesttakeoff"        },
                { "Ready for Departure",    "requesttakeoff"        },
                { "Abort Takeoff",          "aborttakeoff"          },
                { "Cancel Departure",       "aborttakeoff"          },
                { "Directions to Final",    "requestazimuth"        },
                { "Request Vector",         "requestazimuth"        },
                { "Inbound",                "inbound"               },
                { "Abort Inbound",          "abortinbound"          },
                { "Cancel Approach",        "abortinbound"          },
                { "Request Landing",        "requestlanding"        },
                { "Request Taxi for Takeoff","reqtaxifortakeoff"    },
                { "Request Taxi to Parking","reqtaxitoparking"      },
                { "Tower Request Takeoff",  "towerreqtakeoff"       },
                { "Inbound Straight",       "inboundstraight"       },
                { "Overhead Approach",      "approachoverhead"      },
                { "Straight Approach",      "approachstraight"      },
                { "Instrument Approach",    "approachinstrument"    },
                { "Request Vector to Bullseye", "vectortobullseye"  },
                { "Request Vector to Bandit",   "vectortobandit"    },
                { "*Bogey Dope",             "vectortobandit"    }, 
                { "Request Vector to Base", "vectortobase"          },
                { "*Directions to Base",     "vectortobase"          },
                { "Request Vector to Tanker","vectortotanker"       },
                { "*Directions to Tanker",   "vectortotanker"        },
                { "Declare*",                "declare"               },
                { "Request Picture",        "requestpicture"        },
                { "Approaching for Refuel", "intenttorefuel"        },
                { "Abort Refuel",           "abortrefuel"           },
                { "Breakaway",              "abortrefuel"           },
                { "Ready Precontact",       "readyprecontact"       },
                { "Stop Refueling",         "stoprefueling"         },
                { "*Playtime 5 minutes",     "checkin05"             },
                { "*Playtime 10 minutes",    "checkin10"             },
                { "*Playtime 15 minutes",    "checkin15"             },
                { "*Playtime 20 minutes",    "checkin20"             },
                { "*Playtime 25 minutes",    "checkin25"             },
                { "*Playtime 30 minutes",    "checkin30"             },
                { "*Playtime 35 minutes",    "checkin35"             },
                { "*Playtime 40 minutes",    "checkin40"             },
                { "*Playtime 45 minutes",    "checkin45"             },
                { "*Playtime 50 minutes",    "checkin50"             },
                { "*Playtime 55 minutes",    "checkin55"             },
                { "*Playtime 60 minutes",    "checkin60"             },
                { "Check Out",              "checkout"              },
                { "Checking Out",           "checkout"              },
                { "Game Over",              "checkout"              },
                { "Ready to Copy",          "readytocopy"           },
                { "*Remarks",               "readyforremarks"       },
                { "Reading Back",           "ninelinereadback"      },
                { "Copy Nine Line",         "ninelinereadback"      },
                { "Request Tasking",        "requesttasking"        },
                { "Ready for Tasking",      "requesttasking"        },
                { "*New Target",            "requesttasking"        },
                { "Request BDA",            "requestbda"            },
                { "*Damage Report",         "requestbda"            },
                { "What is my Target",      "requesttargetdescr"    },
                { "Unable",                 "unabletocomply"        },
                { "*Showstopper",           "unabletocomply"        },
                { "IP Inbound",             "ipinbound"             },
                { "Copy Miss",              "ipinbound"             },
                { "One Minute",             "oneminute"             },
                { "In Hot",                 "in"                    },
                { "In from the North",      "in"                    },
                { "In from the NorthEast",  "in"                    },
                { "In from the East",       "in"                    },
                { "In from the SouthEast",  "in"                    },
                { "In from the South",      "in"                    },
                { "In from the SouthWest",  "in"                    },
                { "In from the West",       "in"                    },
                { "In from the NorthWest",  "in"                    },
                { "Exit Area",              "off"                   },
                { "Copy Kill",              "attackcomplete"        },
                { "Attack Complete",        "attackcomplete"        },
                { "Advise Ready for BDA",   "advisereadyforbda"     },
                { "Contact",                "contact"               },
                { "Target Visual",          "contact"               },
                { "No Joy",                 "nojoy"                 },
                { "Contact the Mark",       "contactthemark"        },
                { "Tally Mark",             "contactthemark"        },
                { "Tally Smoke",            "contactthemark"        },
                { "Tracking Smoke",         "contactthemark"        },
                { "Sparkle",                "sparkle"               },
                { "Snake",                  "snake"                 },
                { "Pulse",                  "pulse"                 },
                { "Steady",                 "steady"                },
                { "Rope",                   "rope"                  },
                { "Contact Sparkle",        "contactsparkle"        },
                { "Tally Sparkle",          "contactsparkle"        },
                { "Tracking Sparkle",       "contactsparkle"        },
                { "Stop",                   "stop"                  },
                { "Ten Seconds",            "tenseconds"            },
                { "Laser On",               "laseron"               },
                { "Shift Beam",             "shift"                 },
                { "Spot",                   "spot"                  },
                { "Tally Ray",              "spot"                  },
                //{ "Tracking Ray",           "spot"                  },
                { "Tally Beam",             "spot"                  },
                { "Tracking Beam",          "spot"                  },
                { "Terminate",              "terminate"             },
                { "Guns Guns Guns",         "gunsgunsguns"          },
                { "Bombs Away",             "bombsaway"             },
                { "Rifle",                  "rifles"                },
                { "Rockets",                "rockets"               },
                { "Standby for BDA",        "bda"                   },
                { "Standby for Report",     "inflightrep"           },
                { "Request Refuel*",        "requestrefueling"      },
                { "Load Cannon",            "requestcannonreload"   },
                { "Request Rearming",       "requestrearming"       },
                { "Apply Air",              "applyair"              },
                { "Request Repair",         "requestrepair"         },
                { "Stow the Boarding Ladder","stowboardingladder"   },
                { "Run Inertial Starter",   "runinertialstarter"    },
                { "Request HMD",            "requesthmd"            },
                { "Request NVG",            "requestnvg"            },
                { "Turbo On",               "turboon"               },
                { "Turbo Off",              "turbooff"              },
                { "Ground Power On",        "groundpoweron"         },
                { "Ground Power Off",       "groundpoweroff"        },
                { "Place the Wheelchocks",  "wheelchocksplace"      },
                { "Remove the Wheelchocks", "wheelchocksremove"     },
                { "Open the Canopy",        "Seq_J_CANOPY_OPEN"     },
                { "Close the Canopy",       "Seq_J_CANOPY_CLOSE"    },
                { "Connect Air Supply",     "airsupplyconnect"      },
                { "Disconnect Air Supply",  "airsupplydisconnect"   },

                // Carrier Comms

                // CASE I
                // --> Marshal

                { "Inbound for Carrier" ,      "wMsgLeaderInboundCarrier"              },// CASE I
                { "Marking Moms" ,             "wMsgLeaderInboundCarrier"              },// CASE I // forced alias
                { "See You At Ten" ,           "wMsgLeaderSeeYouAtTen"                 },// CASE I
                // --> TOWER

                { "Tower Overhead" ,           "wMsgLeaderTowerOverhead"               },
                { "Overhead" ,                 "wMsgLeaderTowerOverhead"               },// forced alias

                //(to flight for break))
                { "Flight Kiss Off" ,          "wMsgLeaderFlightKissOff"               },// CASE I // force remove
                { "Kiss Off" ,                 "wMsgLeaderFlightKissOff"               },// CASE I // forced alias
                
                // --> LSO , in groove

                { "Hornet Ball" ,              "wMsgLeaderHornetBall"                  },
                { "Tomcat Ball" ,              "wMsgLeaderHornetBall"                  },
                { "Hawkeye Ball" ,             "wMsgLeaderHornetBall"                  },
                { "Viking Ball" ,              "wMsgLeaderHornetBall"                  },
                { "Phantom Ball" ,             "wMsgLeaderHornetBall"                  },
                { "Greyhound Ball" ,           "wMsgLeaderHornetBall"                  },
                { "Intruder Ball" ,            "wMsgLeaderHornetBall"                  },
                { "Lightning Ball" ,           "wMsgLeaderHornetBall"                  },
                { "Prowler Ball" ,             "wMsgLeaderHornetBall"                  },
                { "Skyhawk Ball" ,             "wMsgLeaderHornetBall"                  },

                { "Ball" ,                     "wMsgLeaderHornetBall"                  }, // forced alias

                { "Clara" ,                    "wMsgLeaderCLARA"                       },


                { "Confirm" ,                  "wMsgLeaderConfirm"                     },

                { "Confirm Remaining Fuel" ,   "wMsgLeaderConfirmRemainingFuel"        }, 
                { "Low State" ,                "wMsgLeaderConfirmRemainingFuel"        },// forced

                { "Inbound Marshall Respond" ,  "wMsgLeaderInboundMarshallRespond"     }, // force remove
                { "Expect On Time" ,            "wMsgLeaderInboundMarshallRespond"     }, // forced
                
                { "Established" ,              "wMsgLeaderEsteblished"                 }, 
                { "Commencing" ,               "wMsgLeaderCommencing"                  },// CASE III
                { "Checking In" ,              "wMsgLeaderChecingIn"                   },// CASE III
                { "Approach Check In" ,        "wMsgLeaderChecingIn"                   },// CASE III // forced
                { "Platform" ,                 "wMsgLeaderPlatform"                    },// CASE III

                { "Say Needle" ,               "wMsgLeaderSayNeedle"                   }, // force removed 
                { "Needles" ,                  "wMsgLeaderSayNeedle"                   }, // forced add


                { "Meatball" ,                 "wMsgLeaderBall"                        },// CASE I //forced

                { "Salute" ,                   "crewsalute"                            },
                { "Request Launch" ,           "crewrequestcatlaunch"                  },

                { "Airborne"   ,                "wMsgLeaderAirborn"                    },
                { "Passing 2 5 Kilo",           "wMsgLeaderPassing2_5Kilo"             },

                // Replies

                { "Roger",                  "roger"                 },
                { "Copy",                   "copy"                  },
                { "Affirm",                 "affirm"                },
                { "Wilco",                  "wilco"                 },
                { "Negative",               "negative"              },
                { "Repeat",                 "repeat"                },
                { "Say Again",              "repeat"                },

                { "Take 1",                 "menu01"                },
                { "Take 2",                 "menu02"                },
                { "Take 3",                 "menu03"                },
                { "Take 4",                 "menu04"                },
                { "Take 5",                 "menu05"                },
                { "Take 6",                 "menu06"                },
                { "Take 7",                 "menu07"                },
                { "Take 8",                 "menu08"                },
                { "Take 9",                 "menu09"                },
                { "Take 10",                "menu10"                },
                { "Take 11",                "menu11"                },
                { "Take 12",                "menu12"                },

                // special
                { "Switch*",                "switch"                },
                { "Select",                 "select"                },
                { "Options",                "options"               },

                // aocs
                { "Interrogate",            "state"                 },
                { "Status",                 "state"                 },
                { "Briefing",               "readbriefing"          },

                { "Show Notes",            "wMsgKneeboardShowNotes"       },
                { "Clear Notes",           "wMsgKneeboardClearNotes"      },
                { "Start Dictate",         "wMsgKneeboardDictateStart"    },
                { "End Dictate",           "wMsgKneeboardDictateStop"     },
                { "Correction",            "wMsgKneeboardCorrection"      },
                { "Show Log",              "wMsgKneeboardShowLog"         },
                { "Show Tasking Order",    "wMsgKneeboardShowLog"         },

                { "Page",                  "wMsgShowKneeboardTab"         },

            };

        }
    }

}
