// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IApplicationLanguagesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (ApplicationLanguages))]
  [Guid(502324815, 1835, 19835, 143, 6, 203, 45, 180, 15, 43, 181)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IApplicationLanguagesStatics2
  {
    IVectorView<string> GetLanguagesForUser(User user);
  }
}
