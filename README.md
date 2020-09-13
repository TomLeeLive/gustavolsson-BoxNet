# BoxNet

BoxNet is a reimplementation of XNA's networking library that may be used with [MonoGame](https://www.monogame.net/) or [FNA](https://fna-xna.github.io/) to port networked XNA games to PC.

## Instructions

**Note that this project is far from complete and may not work for your game just yet. I've disabled issues and PRs for the time being and will re-open them once the library is ready. Feel free to try it out nontheless!**

1. Clone this repository next to or as a submodule to your game repository
2. Add the Lidgren project to your solution (`LidgrenNet\Lidgren.Network\Lidgren.Network.csproj`)
3. Add the BoxNet project to your solution (`BoxNet\BoxNet.csproj`)
4. Add a reference to the BoxNet project in your game project
5. Replace all `using Microsoft.Xna.Framework.Net;` with `using BoxNet;` in your code
6. Replace all `using Microsoft.Xna.Framework.GamerServices;` with `using BoxNet.GamerServices;` in your code
7. Set the necessary properties of `NetworkSettings` when your game starts up
    - `GameAppId` - A string uniquely identifying your game. Use for example the Assembly GUID of your game project here. (Required)
    - `Port` - The port your game is using when hosting games (Optional)
    - `MasterServerAddress` - The address to the master (Optional)
    - `MasterServerPort` - The port to use for hosting the master server (Optional)

## Hosting a master server

TODO

## Notes

* The LidgrenNet folder is a Git subtree of `https://github.com/lidgren/lidgren-network-gen3`
