// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceQualifierPersistence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Possible values for the persistence of a global qualifier value override.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ResourceQualifierPersistence
  {
    /// <summary>The override value is not persistent.</summary>
    None,
    /// <summary>The override value persists on the local machine.</summary>
    LocalMachine,
  }
}
