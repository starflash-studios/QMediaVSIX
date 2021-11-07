// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.CustomSystemEventTriggerRecurrence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies when a CustomSystemEventTrigger may be activated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum CustomSystemEventTriggerRecurrence
  {
    /// <summary>The trigger can only be activated once per session.</summary>
    Once,
    /// <summary>The trigger can always be activated.</summary>
    Always,
  }
}
