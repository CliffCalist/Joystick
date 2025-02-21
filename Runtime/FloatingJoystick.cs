using UnityEngine.EventSystems;

namespace WhiteArrow.UI
{
    public class FloatingJoystick : Joystick
    {
        protected override void Start()
        {
            background.gameObject.SetActive(false);
            base.Start();
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
            background.gameObject.SetActive(true);
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            background.gameObject.SetActive(false);
        }
    }
}