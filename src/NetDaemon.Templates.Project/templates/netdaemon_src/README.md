# Project template for binary deploy
This is the project template for source deploy. You will use this template if you want to deploy your NetDaemon apps as is and let NetDaemon runtime compile them at run-time. This allows you to easier edit the files in source editor in Home Assistant like Visual Studio Code server.  

## How to use this template

1. Review your `appsettings.json` and set your settings accordingly. We recommend using a `appsettings.Development.json`. That file will not be copied when you deploy the apps
2. Develop and debug your apps in the apps folder. 
3. Deploy your apps by copy all content (.cs and .yaml files) under the apps folder to your target directory. If you are running an add-on that directory is `/config/netdaemon3` or the directory you mapped to in your docker container or deployment site directory.. Do **NOT** copy the debug project and the files under `DebugProject` folder!!

Have fun!

## Getting started
Please see [netdaemon.xyz](https://netdaemon.xyz/docs/v3) for more information about getting starting developing apps for Home Assistant using NetDaemon.

[![buymeacoffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/ij1qXRM6E)

## Issues

- If you have issues or suggestions of improvements to this template, please [add an issue](https://github.com/net-daemon/netdaemon-app-template)
- If you have issues or suggestions of improvements to NetDaemon, please [add an issue](https://github.com/net-daemon/netdaemon/issues)

## Discuss the NetDaemon

Please [join the Discord server](https://discord.gg/K3xwfcX) to get support or if you want to contribute and help others.
