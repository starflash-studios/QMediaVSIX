// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1956871697, 11957, 17543, 176, 213, 44, 103, 144, 224, 19, 233)]
  [ExclusiveTo(typeof (User))]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IUserStatics2
  {
    User GetDefault();
  }
}
