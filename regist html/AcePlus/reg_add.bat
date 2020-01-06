reg add HKEY_CLASSES_ROOT\RacuosLauncher /f
reg add HKEY_CLASSES_ROOT\RacuosLauncher /t REG_SZ /d "URL:RacuosLauncher Protocol" /f
reg add HKEY_CLASSES_ROOT\RacuosLauncher /v "URL Protocol" /t REG_SZ /f

reg add HKEY_CLASSES_ROOT\RacuosLauncher\DefaultIcon /f

reg add HKEY_CLASSES_ROOT\RacuosLauncher\shell /f

reg add HKEY_CLASSES_ROOT\RacuosLauncher\shell\open /f

reg add HKEY_CLASSES_ROOT\RacuosLauncher\shell\open\command /f
reg add HKEY_CLASSES_ROOT\RacuosLauncher\shell\open\command /t REG_SZ /d "C:\Contact\RacuosLaunch\RacuosLauncher.exe %%1" /f

