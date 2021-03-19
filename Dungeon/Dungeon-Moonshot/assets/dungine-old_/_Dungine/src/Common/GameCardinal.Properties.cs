using System;
using System.Collections.Generic;
using System.Text;

namespace Dungine.Common
{
    public partial class GameCardinal
    {
        /* This class defines the following details about a room cardinal directions:
 *
 *  ToRoomNumber: What room this direction leads to (i.e. "1")
 *       Actions: Available actions in this direction (i.e. "go", "take")
 *       Objects: Objects in this direction (i.e. "door", "table"
 *
 * Please refer to the Dungine documentation for more information.
 */


        public string ToRoomNumber { get; set; }
        public List<string> Actions { get; set; }
        public List<string> Objects { get; set; }

    }
}
