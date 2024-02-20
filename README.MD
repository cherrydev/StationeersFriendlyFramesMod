# Friendly Frames

This mod fixes two bugs in how frame structures are implemented and changes the un-build tool for frames to be the angle grinder.

## Bugs

In most scenarios these bugs might go unnoticed or will be benign. On Vulcan or Venus they can easily lead
to the loss of a base. The first bug causes half-built frames (upgraded once from empty) to constantly
exchange heat between the outside temperature and the room they are installed. This happens to all half-built
frames, regardless of if they are bordering a wall or frame. Even a single half-built block in a moderate
room can raise the temperature of a room catastrophically over a single day on Vulcan.

The second bug triggers when you un-build a fully-upgraded frame to a half-upgraded one. In addition to
the sheet that was used for upgrading, it will also spawn a large grid block's worth of atmosphere from
the outside. It may appear to players that the block is 'storing' the atmosphere in it when it becomes
fully upgraded, but this is not the case. This happens even if the block was fully upgraded in an indoor
atmosphere or in a vacuum. If you do this on Vulcan, you will, at best, end up with 2 deadly poisons
in the room. If you do this during mid-day on Vulcan, the hot volatiles spawned will instantly cause
a small explosion if the room contains oxygen.

Finally, as an added bonus, this mod changes the downgrade tool for frames from being the wrench to
being the angle grinder. I know the game isn't supposed to be easy, but mis-clicking on a pipe and ending
up venting my base to the outside is not part of the challenge I'm looking for.

## Installation

- First [install BepInEx](https://github.com/jixxed/StationeersMods) the same as how StationeersMod directs it. 
You do not need to install StationeersMod.
- Unzip the [release archive](https://github.com/cherrydev/StationeersFriendlyFramesMod/releases/latest) into the `BepInEx\plugins\` directory.
- **IMPORTANT:** If loading up an old save for the first time switch into the F3 console and run the
`recalculaterooms` command. This only needs to be done once.

## Dedicated Server & Multiplayer

This mod supports multiplayer and dedicated server. All clients and the server need to have it installed. Installation on a dedicated
server is identical. The first time running it on a dedicated server, an administrator must perform a `serverrun recalculaterooms` command.
I would recommend all clients disconnect and reconnect. Clients do not need to perform the `recalculaterooms` command.

## Building this mod

Update the file ending in `VS.props` to point the `<StationeersDirectory>` path to point to your
Stationeers install directory. This will automatically re-install the mod in your `BepInEx\plugins\`
directory each time you build the project. Then, open up the `.sln` file in Visual Studio.