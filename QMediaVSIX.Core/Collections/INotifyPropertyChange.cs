using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QMediaVSIX.Core.Collections;

public interface INotifyPropertyChange : INotifyPropertyChanging, INotifyPropertyChanged {
	void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null );
	void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null );
}