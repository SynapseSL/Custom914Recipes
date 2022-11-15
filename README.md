# WARNING
This Plugin is currently obsolte and won't work

# Custom914Recipes
This Plugin allows Hoster to configure SCP-914 and even use the IDs of Custom Items so that you can get a [Tranquilizer](https://github.com/SynapseSL/MoreWeapons) in 914 or other Items

## Installation
1. [Install Synapse](https://github.com/SynapseSL/Synapse/wiki#hosting-guides)
2. Place the Custom914Recipes.dll file in your plugin directory
3. Restart/Start your server.

## Custom Config.syml
Since the default Config is over 450 lines long it creates his own config file named `SCP914Recipes.syml`.
You can find it at the same location than the config.syml.

## Config
A Small Example for the Config
```
[SCP914Recipes]
{
scp914Recipes:
- itemID: 15
  rough:
  - -1
  coarse:
  - -1
  oneToOne:
  - -1
  fine:
  - 11
  - -1
  - -1
  veryFine:
  - -1
}
```
This Config would destroy every item except for the Flashlight and replace it with a chanche of 33% on fine with a O5 Keycard
