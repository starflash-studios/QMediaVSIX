// Decompiled with JetBrains decompiler
// Type: Windows.Management.Update.IPreviewBuildsState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Update
{
  [Guid(2733805630, 45603, 24419, 117, 70, 62, 142, 172, 7, 10, 46)]
  [ExclusiveTo(typeof (PreviewBuildsState))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPreviewBuildsState
  {
    ValueSet Properties { get; }
  }
}
