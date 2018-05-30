﻿public class TriggerEvent_PlayAnimation : TriggerAction_Event
{
    public TriggerAction_Event OnAnimationFinishedEvent;

    private iActionTrigger_EffectController m_EffectController;

    public override void StartEvent()
    {
        m_EffectController.ActivateEffect_Action();
    }

    void Start()
    {
        m_EffectController = GetComponent<iActionTrigger_EffectController>();
        if (m_EffectController != null)
            m_EffectController.Init(EffectFinishedHandler);
    }

    void EffectFinishedHandler()
    {
        if (OnAnimationFinishedEvent != null)
            OnAnimationFinishedEvent.StartEvent();
    }
}
