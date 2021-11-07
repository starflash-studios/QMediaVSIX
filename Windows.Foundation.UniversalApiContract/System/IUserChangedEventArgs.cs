// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(140794332, 6342, 18651, 188, 153, 114, 79, 185, 32, 60, 204)]
  [ExclusiveTo(typeof (UserChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserChangedEventArgs
  {
    User User { get; }
  }
}
