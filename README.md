# Weather Unity

A Unity environment demo that combines third-person movement, weather effects, collectibles, audio, and respawn behaviour.

## Open the project

**Unity:** 6000.4.7f1

1. Clone the repository.
2. Open it in Unity Hub.
3. Use Unity 6000.4.7f1.
4. Open `Assets/Scenes/GetStarted_Scene.unity`.
5. Enter Play Mode.

## What is in the demo

- third-person character controls
- rain and snow VFX prefabs
- day, sunset, and night skybox assets
- collectible stars
- collectible counter UI
- movement-based audio
- player respawn logic
- Cinemachine camera setup
- Universal Render Pipeline

## Main code

| Script | Purpose |
| --- | --- |
| `Assets/SourceFiles/Scripts/ThirdPersonController.cs` | Player movement and camera control |
| `Assets/SourceFiles/Scripts/RespawnPlayer.cs` | Returns the player to the starting area after a fall |
| `Assets/SourceFiles/Scripts/Pickup.cs` | Rotates, bobs, and collects pickup objects |
| `Assets/SourceFiles/Scripts/UpdateCollectibleCount.cs` | Updates the remaining collectible UI |
| `Assets/SourceFiles/Scripts/MotionAudioController.cs` | Plays and fades movement audio |

## Useful assets

```text
Assets/Scenes/        Main scene
Assets/VFX/           Rain and snow effects
Assets/Skyboxes/      Environment skyboxes
Assets/Prefabs/       Player, collectible, and environment prefabs
Assets/Audio/         Ambient and movement audio
```

## Status

This is a working Unity prototype built from Unity starter content and custom gameplay changes.

The next cleanup is focused on a few implementation details in the custom scripts, without changing the scene design. See [Issue #2](https://github.com/jumiknows/Weather-Unity/issues/2).

## Notes

Some assets come from Unity sample or starter content. Check the relevant asset licenses before reusing them outside this project.
