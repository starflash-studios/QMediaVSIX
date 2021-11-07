// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailManager))]
  [Guid(1248994197, 33854, 18757, 179, 170, 52, 158, 7, 163, 98, 197)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailManagerStatics3
  {
    EmailManagerForUser GetForUser(User user);
  }
}
