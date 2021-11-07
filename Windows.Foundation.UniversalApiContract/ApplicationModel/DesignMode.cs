// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DesignMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Enables you to detect whether your app is in design mode in a visual designer.</summary>
  [Static(typeof (IDesignModeStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDesignModeStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class DesignMode
  {
    /// <summary>Used to enable or disable user code inside a XAML designer that targets the Windows 10 Fall Creators Update SDK, or later.</summary>
    /// <returns>**True** if called from code running inside a XAML designer that targets the Windows 10 Fall Creators Update, or later; otherwise **false**.</returns>
    public static extern bool DesignMode2Enabled { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the process is running in design mode.</summary>
    /// <returns>**True** if the process is running in design mode; otherwise **false**.</returns>
    public static extern bool DesignModeEnabled { [MethodImpl] get; }
  }
}
