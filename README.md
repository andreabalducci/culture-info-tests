# Repro for CultureInfo issue

1. Clone the repo
2. run ```dotnet test```

## On Windows

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
[xUnit.net 00:00:00.86]     TimeTest.FirstDayOfWeekTest.test_net6 [FAIL]
  Failed TimeTest.FirstDayOfWeekTest.test_net6 [9 ms]
  Error Message:
   Assert.Equal() Failure
Expected: Monday
Actual:   Sunday
  Stack Trace:
     at TimeTest.FirstDayOfWeekTest.test_net6() in C:\temp\culture-info-tests\FirstDayOfWeekTest.cs:line 13

Failed!  - Failed:     1, Passed:     0, Skipped:     0, Total:     1, Duration: < 1 ms - TimeTest.dll (net6.0)
```
