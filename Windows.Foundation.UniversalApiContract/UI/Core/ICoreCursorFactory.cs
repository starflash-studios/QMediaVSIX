// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreCursorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(4130706977, 42909, 20179, 140, 50, 169, 239, 157, 107, 118, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreCursor))]
  [WebHostHidden]
  internal interface ICoreCursorFactory
  {
    CoreCursor CreateCursor(CoreCursorType type, uint id);
  }
}
