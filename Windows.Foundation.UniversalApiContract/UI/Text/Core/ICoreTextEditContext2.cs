﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextEditContext2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [Guid(2978381243, 2107, 18913, 178, 129, 43, 53, 214, 43, 244, 102)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CoreTextEditContext))]
  internal interface ICoreTextEditContext2
  {
    event TypedEventHandler<CoreTextEditContext, object> NotifyFocusLeaveCompleted;
  }
}