import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InventoryMovementComponent } from './inventory-movement.component';

describe('InventoryMovementComponent', () => {
  let component: InventoryMovementComponent;
  let fixture: ComponentFixture<InventoryMovementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InventoryMovementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InventoryMovementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
