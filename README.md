# Unity Practice 1: X Bot Swing Dancing

This repository is a Unity project skeleton for the assignment: "Practice 1: Using Adobe Mixamo Model".

Important note:
- The actual Mixamo FBX files are not committed here because Adobe Mixamo assets are licensed/downloaded files and are usually not stored in a Git repo.
- You must download the X Bot model and Swing Dancing animation from Mixamo manually in Unity, then import them into the folders below.
- This repository is prepared so you can start the Unity project quickly and follow the required workflow.

## Project structure

- `Assets/Models/` - place the X Bot FBX model here
- `Assets/Animations/` - place the Swing Dancing FBX animation here
- `Assets/Controllers/` - place the Animator Controller here
- `Assets/Scripts/` - C# scripts for setup/start animation if needed

## Required Unity steps

### 1. Download resources from Mixamo

1. Open https://www.mixamo.com/
2. Search and select the X Bot character.
3. Download the model as FBX.
4. Select the Swing Dancing animation.
5. Download the animation as FBX.
6. Use the recommended options:
   - Model: FBX, with skin
   - Animation: FBX, without skin if possible

### 2. Import to Unity

Create folders:
- `Assets/Models`
- `Assets/Animations`
- `Assets/Controllers`

Then import:
- `X Bot` model into `Assets/Models`
- `Swing Dancing` animation into `Assets/Animations`

### 3. Create Animator Controller

In the `Assets/Controllers` folder:
1. Right-click -> Create -> Animator Controller
2. Name it: `XBotAnimatorController`
3. Open the Animator window
4. Drag the Swing Dancing clip into the Animator graph
5. Set this state as the default state
6. Press Play to test

### 4. Add Animator component

1. Select the X Bot GameObject in the Hierarchy
2. Make sure it has an Animator component
3. Assign `XBotAnimatorController` to `Controller`
4. Check the Avatar and Rig settings

### 5. Test result

1. Press Play in the Unity Editor
2. Confirm the robot performs Swing Dancing
3. Check the Console for errors
4. If the animation does not play, verify:
   - Animator controller assigned correctly
   - Avatar is valid
   - FBX rig is set to Humanoid / Animation Type is correct
   - Animation clip is not missing or imported incorrectly

## Helper script

A runtime script is included in `Assets/Scripts/XBotSwingDanceActivator.cs` to automatically trigger the animation when the scene starts.

Use it as a fallback if the Animator state is not playing immediately after import.

## Final checklist

- [ ] X Bot FBX downloaded from Mixamo
- [ ] Swing Dancing FBX downloaded from Mixamo
- [ ] Model imported into Unity
- [ ] Animation imported into Unity
- [ ] Animator controller created (`XBotAnimatorController`)
- [ ] Animator component assigned to the model
- [ ] X Bot plays Swing Dancing on Play
- [ ] No serious console errors

## Notes

For submission, add screenshots of:
- Scene/Game view
- Hierarchy
- Animator window
- Inspector with Animator and Controller assigned

This ensures the assignment evidence is complete.
