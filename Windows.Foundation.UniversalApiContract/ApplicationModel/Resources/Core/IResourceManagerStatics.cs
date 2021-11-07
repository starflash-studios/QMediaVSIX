// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(482409980, 27118, 20035, 153, 1, 71, 241, 38, 135, 186, 247)]
  [ExclusiveTo(typeof (ResourceManager))]
  internal interface IResourceManagerStatics
  {
    ResourceManager Current { get; }

    bool IsResourceReference(string resourceReference);
  }
}
