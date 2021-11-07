// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaSourceState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the state of a MediaSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum MediaSourceState
  {
    /// <summary>The **MediaSource** has been initialized.</summary>
    Initial,
    /// <summary>The **MediaSource** is in the process of opening the associated media content.</summary>
    Opening,
    /// <summary>The **MediaSource** has successfully opened the associated media content.</summary>
    Opened,
    /// <summary>The **MediaSource** failed to open the associated media content.</summary>
    Failed,
    /// <summary>The **MediaSource** has been closed.</summary>
    Closed,
  }
}
