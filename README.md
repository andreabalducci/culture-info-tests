# Repro for CultureInfo issue

1. Clone the repo
2. run ```dotnet test```

## On Windows 10 21H2

```
Test run for C:\temp\culture-info-tests\bin\Debug\net48\TimeTest.dll (.NETFramework,Version=v4.8)
Microsoft (R) Test Execution Command Line Tool Version 17.2.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration:  - TimeTest.dll (net48)
Test run for C:\temp\culture-info-tests\bin\Debug\net6.0\TimeTest.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.2.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.54]     TimeTest.FirstDayOfWeekTest.test_en_au [FAIL]
  Failed TimeTest.FirstDayOfWeekTest.test_en_au [13 ms]
  Error Message:
   Assert.Equal() Failure
Expected: Monday
Actual:   Sunday
  Stack Trace:
     at TimeTest.FirstDayOfWeekTest.test_en_au() in C:\temp\culture-info-tests\FirstDayOfWeekTest.cs:line 26
  Standard Output Messages:
 Current UI culture English (United States) => First day of week is Sunday
 Current    culture Italian (Italy) => First day of week is Monday
 Test       culture English (Australia) => First day of week is Sunday



dotnet --version
6.0.300-preview.22204.3
```

## On MacOs Monterey 12.4 (21F79)

```
Test run for /Users/andrea/dev/TimeTest/bin/Debug/net6.0/TimeTest.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.3.0 (arm64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - /Users/andrea/dev/TimeTest/bin/Debug/net6.0/TimeTest.dll (net6.0)

Current UI culture English (Italy) => First day of week is Monday
Current    culture English (Italy) => First day of week is Monday
Test       culture English (Australia) => First day of week is Monday

dotnet --version 
6.0.400-preview.22330.6
```

## Results

Net 4.8 works as expected

Net 6.0 breaks on Windows 

Net 6.0 works as expected on MacOs




