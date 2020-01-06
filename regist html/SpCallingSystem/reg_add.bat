reg add HKEY_CLASSES_ROOT\SpCallingSystem /f
reg add HKEY_CLASSES_ROOT\SpCallingSystem /t REG_SZ /d "URL:SpCallingSystem Protocol" /f
reg add HKEY_CLASSES_ROOT\SpCallingSystem /v "URL Protocol" /t REG_SZ /f

reg add HKEY_CLASSES_ROOT\SpCallingSystem\DefaultIcon /f

reg add HKEY_CLASSES_ROOT\SpCallingSystem\shell /f

reg add HKEY_CLASSES_ROOT\SpCallingSystem\shell\open /f

reg add HKEY_CLASSES_ROOT\SpCallingSystem\shell\open\command /f
reg add HKEY_CLASSES_ROOT\SpCallingSystem\shell\open\command /t REG_SZ /d "C:\Contact\SpCallingSystem\SpCallingSystemStartUp.exe %%1" /f