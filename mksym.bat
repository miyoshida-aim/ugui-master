cd /d %~dp0

cd Assets\Plugins\UniRx\
rm Scripts
mklink /D Scripts ..\..\..\submodules\UniRx\Assets\Plugins\UniRx\Scripts

rem cd /d %~dp0

rem cd "Assets\LINQtoGameObject"
rem rm Scripts
rem mklink /D Scripts "..\..\submodules\LINQ-to-GameObject-for-Unity\Assets\LINQtoGameObject\Scripts"

cd /d %~dp0
pause