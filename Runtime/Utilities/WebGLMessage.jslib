mergeInto(LibraryManager.library, {
  
  SendWebRequest: function(json)
  {
    sendScore(Pointer_stringify(json));
  },

});