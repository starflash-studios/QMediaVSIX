// Decompiled with JetBrains decompiler
// Type: Windows.System.MemoryManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides access to information on an app's memory usage.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMemoryManagerStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMemoryManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMemoryManagerStatics4), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMemoryManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class MemoryManager
  {
    /// <summary>Gets the amount of memory that your app may expect to have available.</summary>
    /// <returns>The expected memory cap in bytes.</returns>
    public static extern ulong ExpectedAppMemoryUsageLimit { [MethodImpl] get; }

    /// <summary>Tries to set a specific memory cap for the current app or task. In cases where memory caps are shared between foreground and background components, any difference between the default cap and the new request will be assigned to the other component.</summary>
    /// <param name="value">The new memory limit to set.</param>
    /// <returns>**True** if the operation succeeded; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TrySetAppMemoryUsageLimit(ulong value);

    /// <summary>Gets an AppMemoryReport for the app, which provides information about its memory usage.</summary>
    /// <returns>Information about the process' memory usage.</returns>
    [MethodImpl]
    public static extern AppMemoryReport GetAppMemoryReport();

    /// <summary>Gets a ProcessMemoryReport for a process, which provides information about its memory usage.</summary>
    /// <returns>Information about the process' memory usage.</returns>
    [MethodImpl]
    public static extern ProcessMemoryReport GetProcessMemoryReport();

    /// <summary>Gets the app's current memory usage.</summary>
    /// <returns>The app's current memory usage in bytes.</returns>
    public static extern ulong AppMemoryUsage { [MethodImpl] get; }

    /// <summary>Gets the app's memory usage limit.</summary>
    /// <returns>The app's memory usage limit in bytes.</returns>
    public static extern ulong AppMemoryUsageLimit { [MethodImpl] get; }

    /// <summary>Gets the app's memory usage level.</summary>
    /// <returns>The app's memory usage level.</returns>
    public static extern AppMemoryUsageLevel AppMemoryUsageLevel { [MethodImpl] get; }

    /// <summary>Raised when the app's memory consumption has increased to a higher value in the AppMemoryUsageLevel enumeration.</summary>
    public static extern event EventHandler<object> AppMemoryUsageIncreased;

    /// <summary>Raised when the app's memory consumption has decreased to a lower value in the AppMemoryUsageLevel enumeration.</summary>
    public static extern event EventHandler<object> AppMemoryUsageDecreased;

    /// <summary>Raised just before the limit of how much total memory the app can use is changed.</summary>
    public static extern event EventHandler<AppMemoryUsageLimitChangingEventArgs> AppMemoryUsageLimitChanging;
  }
}
