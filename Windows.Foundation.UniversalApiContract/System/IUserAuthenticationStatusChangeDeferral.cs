// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserAuthenticationStatusChangeDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (UserAuthenticationStatusChangeDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2293601640, 47920, 17147, 162, 112, 233, 144, 46, 64, 239, 167)]
  internal interface IUserAuthenticationStatusChangeDeferral
  {
    void Complete();
  }
}
