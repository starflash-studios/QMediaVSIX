// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FilePickerSelectedFilesArray
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  /// <summary>Represents a collection of storage files that the user has selected by using a file picker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FilePickerSelectedFilesArray : IVectorView<StorageFile>, IIterable<StorageFile>
  {
    [MethodImpl]
    public extern StorageFile GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(StorageFile value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] StorageFile[] items);

    [MethodImpl]
    public extern IIterator<StorageFile> First();
  }
}
