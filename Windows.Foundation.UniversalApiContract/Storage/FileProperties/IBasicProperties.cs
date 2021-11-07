// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IBasicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BasicProperties))]
  [Guid(3495777755, 30814, 19046, 190, 2, 155, 238, 197, 138, 234, 129)]
  internal interface IBasicProperties
  {
    ulong Size { get; }

    DateTime DateModified { get; }

    DateTime ItemDate { get; }
  }
}
