// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IUserIdentity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(558291405, 1858, 19427, 138, 28, 124, 122, 230, 121, 170, 136)]
  [ExclusiveTo(typeof (UserIdentity))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserIdentity
  {
    IVectorView<OnlineIdServiceTicket> Tickets { get; }

    string Id { get; }

    string SafeCustomerId { get; }

    string SignInName { get; }

    string FirstName { get; }

    string LastName { get; }

    bool IsBetaAccount { get; }

    bool IsConfirmedPC { get; }
  }
}
