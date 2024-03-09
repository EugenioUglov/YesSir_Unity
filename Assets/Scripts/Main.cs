using Controllers;
using UnityEngine;

public class Main : MonoBehaviour
{
    [Header("Links")]
    [SerializeField] private ActionBlockController _actionBlockController;
    [SerializeField] private DragAndDropController _dragAndDropController;
    [SerializeField] private SearchController _searchController;
    [SerializeField] private CommandController _commandController;
    [SerializeField] private LoaderFullscreenService _loaderFullscreenService;


    private void Start()
    {
        UserSettings userSettings = new UserSettings();

        userSettings.ApplySettings();
        _dragAndDropController.Init();
        _searchController.Init();
        _actionBlockController.Init();

        _actionBlockController.CreateActionBlockByPath(@"D:\Projects\Unity\TypewriterEffectForText-Unity-main.zip");
    }

    // void Update()
    // {
    //     if (_searchController.IsSelectedInputField() == false && _commandController.IsSelectedInputField() == false)
    //     {
    //         _searchController.FocusInputField();
    //     }
    // }

    
    public void Quit()
    {
        UnityEngine.Application.Quit();
    }
}