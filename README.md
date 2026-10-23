# TABS-MOD

A starter BepInEx 5 plugin for Totally Accurate Battle Simulator (TABS).

## Current milestone

The starter plugin logs `TABS Starter Mod loaded successfully.` when BepInEx loads it. This confirms the plugin was discovered and initialized; it does not add gameplay features yet.

## Build requirements

This public repository intentionally does **not** include TABS game DLLs.

The GitHub Actions workflow expects a separate **private** repository containing reference assemblies. Create one (for example, `MALTer1/TABS-Game-References`) and upload these files from your TABS installation's `TotallyAccurateBattleSimulator_Data/Managed` folder:

- `UnityEngine.dll` (if present)
- `UnityEngine.CoreModule.dll`

Keep those files private. The project does not currently need `Assembly-CSharp.dll`; we can add it later if a feature needs TABS-specific game types.

Then open **TABS-MOD → Settings → Secrets and variables → Actions** and add repository secrets:

- `TABS_REFERENCE_REPO`: private repository name, such as `MALTer1/TABS-Game-References`
- `TABS_REFERENCE_TOKEN`: a fine-grained personal access token with **Contents: Read-only** access to that private repository

The workflow downloads BepInEx 5.4.23.3, checks out the private references, and compiles the plugin. The resulting DLL is published in the workflow run's **Artifacts** section.

## Install

After a successful build, download the `TabsStarterMod.dll` artifact and place it in:

`TotallyAccurateBattleSimulator/BepInEx/plugins/`

Create the `plugins` folder if it does not exist. Start TABS and check `BepInEx/LogOutput.log` for the startup message.

## Important

- Never commit proprietary game DLLs to this public repository.
- The first build may need adjustments based on the exact assemblies present in your installation.
- This is a starter scaffold; custom units, factions, and gameplay features come after we confirm the plugin loads.
