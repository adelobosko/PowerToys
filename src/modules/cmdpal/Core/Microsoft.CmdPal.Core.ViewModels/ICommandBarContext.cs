// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CmdPal.Core.ViewModels.Messages;

namespace Microsoft.CmdPal.Core.ViewModels;

// Represents everything the command bar needs to know about to show command
// buttons at the bottom.
//
// This is implemented by both ListItemViewModel and ContentPageViewModel,
// the two things with sub-commands.
public interface ICommandBarContext : IContextMenuContext
{
    public string SecondaryCommandName { get; }

    public CommandItemViewModel? PrimaryCommand { get; }

    public CommandItemViewModel? SecondaryCommand { get; }
}
