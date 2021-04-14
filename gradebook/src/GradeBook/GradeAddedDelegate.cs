using System;

namespace GradeBook
{
    // When creating a delegate for events, it's a convention to pass a "sender" of type object and EventArgs.
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
}