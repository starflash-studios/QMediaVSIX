// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreCursor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreCursor))]
  [Guid(2525575887, 4381, 17452, 138, 119, 184, 121, 146, 248, 226, 214)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreCursor
  {
    uint Id { get; }

    CoreCursorType Type { get; }
  }
}
